using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using mkvMediaConverter.Properties;

namespace mkvMediaConverter
{
    public partial class FrmMain : Form
    {
        /// <References>
        /// Watcher example borrowed from:
        /// http://www.codeproject.com/Articles/26528/C-Application-to-Watch-a-File-or-Directory-using-F
        /// Conversion Example using FFMPEG borrowed from:
        /// https://github.com/Gigawiz/MKV2MP4
        /// </References>

        private bool _isWatching;
        private string _path;
        private string _CustomTargetPath;
        private FileSystemWatcher _watcher = new FileSystemWatcher();
        private readonly StringBuilder _sb;
        private bool _isBusy;

        #region Public Methods

        public FrmMain()
        {
            InitializeComponent();
            _sb = new StringBuilder();
            _isBusy = false;
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Converts MKV to MP4
        /// </summary>
        /// <param name="infile"></param>
        /// <param name="outfile"></param>
        private void ConvertToMp4(string infile, string outfile)
        {
            string strFileName = Path.GetFileName(infile);
            UpdateStatusStrip(SystemStatus.Converting, strFileName);

            try
            {
                //Setup FFMPEG with params etc
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();

                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg\\ffmpeg.exe");
                startInfo.Arguments = @" -i " + @"""" + infile + @"""" + " -y -vcodec copy -acodec copy " + @" """ + outfile + @""" ";


                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardError = true;
                startInfo.RedirectStandardOutput = true;


                process.StartInfo = startInfo;
                process.ErrorDataReceived += ConsoleDataReceived;
                process.OutputDataReceived += ConsoleDataReceived;

                process.Start();

                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                process.WaitForExit();


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

            UpdateStatusStrip(SystemStatus.FinishedConverting, strFileName);
            UpdateConvertedFilesLog(strFileName);
        }

        private void UpdateConvertedFilesLog(string strFileName)
        {
            StringBuilder _sbBuilder = new StringBuilder();
            _sbBuilder.Append(strFileName);
            _sbBuilder.Append("    ");
            _sbBuilder.Append(DateTime.Now);
            LbConvertedFiles.BeginInvoke((Action)(() =>
            {
                LbConvertedFiles.BeginUpdate();
                LbConvertedFiles.Items.Add(_sbBuilder);
                LbConvertedFiles.EndUpdate();
            }));
        }

        /// <summary>
        /// Sets up and enables Watcher.
        /// </summary>
        /// <param name="path"></param>
        private void Watch(string path)
        {

            if (path == null) throw new ArgumentNullException("path");
            if (_isWatching)//If already Watching
            {
                //Timer();
                UpdateStatusStrip(SystemStatus.Stopped);

                _isWatching = false;
                _watcher.EnableRaisingEvents = false;//Stop Watcher
                _watcher.Dispose();
                BtnWatch.BackColor = Color.ForestGreen;
                BtnWatch.Text = @"Start";
            }
            else
            {
                //Timer();
                if (TxtWtchFldr.Text != "")//If not Watching and watch folder exists
                {
                    UpdateStatusStrip(SystemStatus.Started);

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
                    _watcher.Renamed += _watcher_Renamed;

                    _watcher.EnableRaisingEvents = true; //Start Watcher
                }
            }
        }

        bool _isRunning;
        Stopwatch stopwatch = null;
        private void Timer()
        {

            if (_isRunning == false)
            {
                _isRunning = true;
                stopwatch = Stopwatch.StartNew();
                stopwatch.Start();
                // Capture the elapsed ticks and write them to the console.

                while (_isRunning == true)
                {
                    long ticks1 = stopwatch.ElapsedTicks;
                    statusStrip.BeginInvoke((Action)(() =>
                    {
                        toolStripStatusLabel2.Text = String.Format("Uptime {0}", ticks1);
                        statusStrip.Refresh();
                        statusStrip.Update();
                    }));
                }
            }
            else
            {
                stopwatch.Stop();
                _isRunning = false;

            }
        }

        private DateTime startTime = DateTime.Now;

       

        /// <summary>
        /// The different statuses the system ca be.
        /// </summary>
        enum SystemStatus
        {
            Started,
            Stopped,
            Converting,
            FinishedConverting

        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        /// <param name="name"></param>
        private void UpdateStatusStrip(SystemStatus status, string name = null)
        {
            string strStatusText = "";
            switch (status)
            {
                case SystemStatus.Started:
                    {
                        strStatusText = "Watching Media";
                        break;
                    }
                case SystemStatus.Converting:
                    {
                        strStatusText = string.Format("Converting {0}", name);
                        break;
                    }
                case SystemStatus.FinishedConverting:
                    {
                        strStatusText = string.Format("Finished Converting {0}", name);
                        break;
                    }

                case SystemStatus.Stopped:
                    {
                        strStatusText = string.Format("Stopped Watching Media");
                        break;
                    }
            }


            statusStrip.BeginInvoke((Action)(() =>
            {
                toolStripStatusLabel.Text = String.Format("{0}", strStatusText);
                statusStrip.Refresh();
                statusStrip.Update();
            }));
        }


        /// <summary>
        /// Log any changes
        /// </summary>
        /// <param name="e"></param>
        private void LogFile(FileSystemEventArgs e)
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

        /// <summary>
        /// Logs any rename events
        /// </summary>
        /// <param name="e"></param>
        private void LogFile(RenamedEventArgs e)
        {

            if (_isBusy == false)
            {
                _sb.Remove(0, _sb.Length);
                _sb.Append(e.OldName);
                _sb.Append(" -> ");
                _sb.Append(e.FullPath);
                _sb.Append(" ");
                _sb.Append(e.ChangeType);
                _sb.Append(" ");
                _sb.Append(DateTime.Now);
                _isBusy = true;
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

        #endregion

        #region Form Methods

        private readonly List<byte[]> _bytelist = new List<byte[]>();//Byte sig of already processed files
        private string _outputExtension = null;
        private string _outputFile = null;


        /// <summary>
        /// Processes changes to watch folder
        /// </summary>
        /// <param name="e"></param>
        private void ChangeDetected(FileSystemEventArgs e)
        {
            if (e.ChangeType == WatcherChangeTypes.Created || e.ChangeType == WatcherChangeTypes.Changed)
            {
                //If file is folder
                if (Directory.Exists(e.FullPath))
                {
                    //Get files from folder
                    foreach (string file in Directory.GetFiles(e.FullPath))
                    {
                        if (RbtnMKVtoMP4.Checked)
                        {
                            _outputExtension = ".MP4";
                        }


                        if (!ChkCustomOutput.Checked)
                        {
                            _outputFile = file.Replace(".mkv", _outputExtension);
                        }
                        else
                        {
                            string strFileName = Path.GetFileName(file);
                            _CustomTargetPath = TxtOutput.Text;
                            if (strFileName != null)
                            {
                                strFileName = strFileName.Replace(".mkv", _outputExtension);
                                _outputFile = Path.Combine(_CustomTargetPath, strFileName);
                            }
                        }

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
                                ConvertToMp4(file, _outputFile);
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
                            ChangeDetected(eventArgs);
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
        /// Receives SOUT data from FFMPEG and updates log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsoleDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
                LstFfmpegOutput.BeginInvoke((Action)(() =>
                {
                    LstFfmpegOutput.BeginUpdate();
                    if (e.Data != null) LstFfmpegOutput.Items.Add(e.Data);
                    LstFfmpegOutput.EndUpdate();
                }));
        }

        /// <summary>
        /// Event for when an object is renamed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _watcher_Renamed(object sender, RenamedEventArgs e)
        {
            LogFile(e);
            ChangeDetected(e);
        }

        /// <summary>
        /// Event fires when change detected
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            LogFile(e);
            ChangeDetected(e);
        }


        /// <summary>
        /// Begin/Stop Watching
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnWatch_Click(object sender, EventArgs e)
        {
            if (TxtWtchFldr.Text != null)
            {

                _path = TxtWtchFldr.Text;
                Watch(_path);
            }
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

            //uptime calc
            //StringBuilder _sbBuilder = new StringBuilder();
            //var delta = DateTime.Now - startTime;
            //string seconds = delta.Seconds.ToString("n0");
            //string minutes = Math.Floor(delta.TotalMinutes).ToString("n0");
            //_sbBuilder.AppendFormat("{0}:{1}", minutes, seconds);

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

        /// <summary>
        /// Gets Watch Folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSlctWtchFldr_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                _path = fbd.SelectedPath;
                TxtWtchFldr.Text = fbd.SelectedPath;
            }
        }


        #endregion

        private void BtnSlctCstmFldr_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                _CustomTargetPath = fbd.SelectedPath;
                TxtOutput.Text = fbd.SelectedPath;
            }
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon.Visible = true;
               this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon.Visible = false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }



    }
}
