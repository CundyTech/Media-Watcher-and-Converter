using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using mkvMediaConverter.Properties;

namespace mkvMediaConverter
{
    public partial class BtnClear : Form
    {
        /// <References>
        /// Watcher example borrowed from:
        /// http://www.codeproject.com/Articles/26528/C-Application-to-Watch-a-File-or-Directory-using-F
        /// Conversion Example using FFMPEG borrowed from:
        /// https://github.com/Gigawiz/MKV2MP4
        /// </References>

        private bool _isWatching;
        private string _path;
        private FileSystemWatcher _watcher = new FileSystemWatcher();
        private readonly StringBuilder _sb;
        private bool _isBusy;

        public BtnClear()
        {
            InitializeComponent();
            _sb = new StringBuilder();
            _isBusy = false;
        }

        /// <summary>
        /// Gets Watch Folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSlctWtchFldr_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                _path = fbd.SelectedPath;
                TxtWtchFldr.Text = fbd.SelectedPath;
            }
        }

        /// <summary>
        /// Converts MKV to MP4
        /// </summary>
        /// <param name="infile"></param>
        /// <param name="outfile"></param>
        private void ConvertToMp4(string infile, string outfile)
        {
            var strWatchPath = TxtWtchFldr.Text;//Folder being watched
            var strFfmpegLocation = Directory.GetCurrentDirectory();//Folder of FFMEG exe file

            //Copy FFMPEG exe to root directory
            if (!File.Exists(strWatchPath + @"\ffmpeg.exe"))
            {
                File.Copy(strFfmpegLocation + @"\ffmpeg.exe", strWatchPath + @"\ffmpeg.exe");
            }

            //Setup FFMPEG with params etc
            Process proc = new Process();
            ProcessStartInfo psi = new ProcessStartInfo();

            psi.FileName = strWatchPath + @"\ffmpeg.exe";
            psi.Arguments = @" -i " + @"""" + infile + @"""" + " -y -vcodec copy -acodec copy " + @" """ + outfile + @""" ";

            // var text = psi.Arguments.ToString();
            proc.StartInfo = psi;
            proc.Start();
            proc.WaitForExit();

            try
            {
                //Remove FFMPEG exe after conversion complete
                File.Delete(_path + @"\ffmpeg.exe");
                if (ChkDeleteMkv.Checked)//Delete original mkv?
                {
                    File.Delete(infile);
                }
            }
            catch (Exception ex)
            {
                //Invoke LstOutput and write exception to it.
                LstOutput.BeginInvoke((Action)(() =>
                {
                    LstOutput.BeginUpdate();
                    LstOutput.Items.Add(ex.ToString());
                    LstOutput.EndUpdate();
                }));
            }
        }

        /// <summary>
        /// Sets up and enables Watcher.
        /// </summary>
        /// <param name="path"></param>
        private void Watch(string path)
        {
            if (_isWatching)//If already Watching
            {
                _isWatching = false;
                _watcher.EnableRaisingEvents = false;//Stop Watcher
                _watcher.Dispose();
                BtnWatch.BackColor = Color.ForestGreen;
                BtnWatch.Text = @"Start";
            }
            else
            {
                if (TxtWtchFldr.Text != "")//If not Watching and watch folder exists
                {
                    path = TxtWtchFldr.Text;//Folder to watch
                    _isWatching = true;
                    BtnWatch.BackColor = Color.Red;
                    BtnWatch.Text = @"Stop";

                    _watcher = new FileSystemWatcher();

                    _watcher.Filter = "*.*";//Watch everything in folder

                    _watcher.Path = path + "\\";
                    _watcher.IncludeSubdirectories = true;

                    //Define Filters
                    _watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                                            | NotifyFilters.FileName | NotifyFilters.DirectoryName;

                    //Add listeners
                    _watcher.Changed += OnChanged;
                    _watcher.Created += OnChanged;
                    _watcher.Deleted += OnChanged;

                    _watcher.EnableRaisingEvents = true; //Start Watcher
                }
            }
        }

        /// <summary>
        /// Event fires when change detected
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            LogFile(e);
            ChangeDetected(source, e);
        }

        private readonly List<byte[]> _bytelist = new List<byte[]>();//Byte sig of already processed files
        /// <summary>
        /// Processes changes to watch folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeDetected(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType == WatcherChangeTypes.Created || e.ChangeType == WatcherChangeTypes.Changed)
            {
                //If file is folder
                if (Directory.Exists(e.FullPath))
                {
                    //Get files from folder
                    foreach (string file in Directory.GetFiles(e.FullPath))
                    {

                        string outputfile = file.Replace(".mkv", ".MP4");//prepare output file/location for conversion
                        if (file.EndsWith(".mkv"))//if file is a .mkv
                        {
                            FileInfo info = new FileInfo(file);
                            while (IsFileLocked(info))//Make sure file is finished being copied/moved
                            {
                                Thread.Sleep(500);
                            }

                            //Get byte sig of file and if seen before dont process
                            byte[] myFileData = File.ReadAllBytes(file);
                            byte[] myHash = MD5.Create().ComputeHash(myFileData);

                            if (_bytelist.Count != 0)
                            {
                                foreach (var item in _bytelist)
                                {
                                    //If seen before ignore
                                    if (myHash == item)
                                    {
                                        return;
                                    }
                                }
                            }
                            else//Else add to list
                            {
                                _bytelist.Add(myHash);
                            }

                            //If convert to MP4 option checked
                            if (RbtnMKVtoMP4.Checked)
                            {
                                ConvertToMp4(file, outputfile);
                            }
                            else
                            {
                                //Not Imeplented
                            }
                        }
                        else
                        {
                            //Recursively look into other folders and repeat
                            var eventArgs = new FileSystemEventArgs(
                                WatcherChangeTypes.Created,
                                Path.GetDirectoryName(file),
                                Path.GetFileName(file));
                            ChangeDetected(sender, eventArgs);
                        }
                    }
                }
            }
            else
            {
                //Not a create or change so just log
                LogFile(e);
            }
        }

        /// <summary>
        /// Log any changes
        /// </summary>
        /// <param name="e"></param>
        private void LogFile(FileSystemEventArgs e)
        {
            if (e.FullPath.EndsWith(".mkv") || e.FullPath.EndsWith(".MP4"))
            {
                if (_isBusy == false)
                {
                    _sb.Remove(0, _sb.Length);
                    _sb.Append(e.FullPath);
                    _sb.Append(" ");
                    _sb.Append(e.ChangeType);
                    _sb.Append("    ");
                    _sb.Append(DateTime.Now);
                    _isBusy = true;
                }
            }
        }

        /// <summary>
        /// Checks if file is locked by another process
        /// Ref:http://stackoverflow.com/a/937558/2468342
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        protected virtual bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }

        /// <summary>
        /// Begin/Stop Watching
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnWatch_Click(object sender, EventArgs e)
        {
            Watch(_path);
        }

        /// <summary>
        /// Check if there are updates pending to be logged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (_isBusy)
            {
                LstOutput.BeginUpdate();
                LstOutput.Items.Add(_sb.ToString());
                LstOutput.EndUpdate();
                _isBusy = false;
            }
        }

        /// <summary>
        /// Use Custom Output path instead of default directory
        /// NOT IMPLEMENTED YET!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChkCustomOutput_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkCustomOutput.Checked)
            {
                TxtOutput.Enabled = true;
            }
            if (ChkCustomOutput.Checked == false)
            {
                TxtOutput.Enabled = false;
            }
        }

        /// <summary>
        /// Load users presets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            BtnWatch.BackColor = Color.ForestGreen;
            TxtWtchFldr.Text = Settings.Default.TxtWtchFldr;
            ChkDeleteMkv.Checked = Settings.Default.ChkDeleteMkv;
        }

        /// <summary>
        /// Save users preset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.ChkDeleteMkv = ChkDeleteMkv.Checked;
            Settings.Default.TxtWtchFldr = TxtWtchFldr.Text;
            Settings.Default.Save();

            //Clean up if File remains
            try
            {
                if (File.Exists(_path + @"\ffmpeg.exe"))
                {
                    File.Delete(_path + @"\ffmpeg.exe");

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Clear Log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClearOutput_Click(object sender, EventArgs e)
        {
            LstOutput.Items.Clear();
        }

    }
}
