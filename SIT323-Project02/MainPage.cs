using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;
using System.Diagnostics;

namespace SIT323_Project02
{
    public partial class MainPage : Form
    {

        public MainPage()
        {
            InitializeComponent();

            //progressBar.Value = 0;
            //progressBar.Maximum = 100;

        }

        private void OpenCrozzleButton_Click(object sender, EventArgs e)
        {
            //DataLoad.EL = new List<ErrorList>();
            LogFile.WriteLogFile("Start Load Crozzle File");
            OpenFile(1);
            LogFile.WriteLogFile("End Load Crozzle File");

        }

        private void OpenConfigButton_Click(object sender, EventArgs e)
        {
            LogFile.WriteLogFile("Start Load configuration File");
            OpenFile(2);
            LogFile.WriteLogFile("End Load configuration File");
            //label1.Text = DataLoad.totalValue.ToString();
        }

        private void OpenFile(int v)
        {
            try
            {
                LogFile.WriteLogFile("start open file dialog, choose file");
                OpenFileDialog fdlg = new OpenFileDialog();
                fdlg.Title = "C# Corner Open File Dialog";
                // inital path
                //fdlg.InitialDirectory = Application.StartupPath;
                //fdlg.InitialDirectory = Environment.CurrentDirectory;
                // filters the file 
                fdlg.Filter = "TXT Files(*.txt)|*.txt|All Files(*.*)|*.*";
                fdlg.FilterIndex = 1;
                fdlg.RestoreDirectory = true;
                if (fdlg.ShowDialog() == DialogResult.OK)
                {
                    LogFile.WriteLogFile(fdlg.FileName.ToString() + " selected.");
                    int length = fdlg.FileName.ToString().Length;
                    string filename = fdlg.FileName;
                    //string filepath = System.IO.Path.GetDirectoryName(fdlg.FileName);
                    if (v == 1)
                    {
                        //LogFile.WriteErrorFile(" ==========Start " + fdlg.FileName.ToString());
                        // intent path of crozzle file to dataload
                        LogFile.WriteLogFile("intent crozzle txt file path to DataLoad.dataload");
                        DataLoad.crozzleDataLoad(filename, 1);
                        LogFile.WriteLogFile("finish loading crozzle txt file");

                        //set word list
                        LogFile.WriteLogFile("Setting All Words in wordlist");
                        WordListlistView.Clear();
                        WordListlistView.BeginUpdate();
                        foreach (TestCrozzleSecondLineNoRepeat tcslnr in DataLoad.TCSLNR)
                        {
                            WordListlistView.Items.Add(tcslnr.wordlist);

                        }
                        WordListlistView.EndUpdate();

                    }
                    else if (v == 2)
                    {
                        //LogFile.WriteErrorFile(" ==========Start " + fdlg.FileName.ToString());
                        // intent path of crozzle file to dataload
                        LogFile.WriteLogFile("intent configuration txt file path to DataLoad.dataload");
                        DataLoad.configurationDataLoad(filename, 2);
                        LogFile.WriteLogFile("finish loading configuration txt file");

                    }
                }
                else
                {
                    LogFile.WriteLogFile("have not select file");
                    //LogFile.WriteErrorFile("ErrorFile Entry : ----" + "please choose a txt file");
                }
            }
            catch (Exception e)
            {
                LogFile.WriteLogFile("Error Entry : ----Exception----" + e.Message);
                //LogFile.WriteErrorFile("Error Entry : ----Exception----" + e.Message);
            }
        }

        private void WordListlistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateCrozzle_Click(object sender, EventArgs e)
        {
            try
            {
                LogFile.WriteLogFile("Start Create Crozzle");
                var sw = Stopwatch.StartNew();

                // Processes all the events
                CreateCrozzle.createCrozzle();

                timer.Text = sw.Elapsed.ToString();

                //CreateCrozzle.createCrozzle();


                label1.Text = CreateCrozzle.totalValue.ToString();
            }
            catch (Exception ex)
            {
                LogFile.WriteLogFile("Error Entry : ----Exception----" + ex.Message);
                //LogFile.WriteErrorFile("Error Entry : ----Exception----" + e.Message);
            }

            try
            {
                CreateCrozzle.addCrozzleTableToDT();
                CrozzlewebBrowser.DocumentText = WriteHTML.ExportDatatableToHtml(CreateCrozzle.dt);
            }
            catch (Exception ex)
            {
                LogFile.WriteLogFile("Error Entry : ----Exception----" + ex.Message);
                //LogFile.WriteErrorFile("Error Entry : ----Exception----" + ex.Message);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void openCrozzleFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogFile.WriteLogFile("Start Load Crozzle File");
            OpenFile(1);
            LogFile.WriteLogFile("End Load Crozzle File");
        }

        private void openConfigurationFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogFile.WriteLogFile("Start Load configuration File");
            OpenFile(2);
            LogFile.WriteLogFile("End Load configuration File");
            //label1.Text = DataLoad.totalValue.ToString();
        }

        private void NErrorlabel_Click(object sender, EventArgs e)
        {

        }

        private void errorTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LogFile.WriteLogFile("Start Create Crozzle");
                var sw = Stopwatch.StartNew();
                CreateCrozzle.createCrozzle();
                timer.Text = sw.Elapsed.ToString();
                label1.Text = CreateCrozzle.totalValue.ToString();
            }
            catch (Exception ex)
            {
                LogFile.WriteLogFile("Error Entry : ----Exception----" + ex.Message);
                //LogFile.WriteErrorFile("Error Entry : ----Exception----" + e.Message);
            }

            try
            {
                CreateCrozzle.addCrozzleTableToDT();
                CrozzlewebBrowser.DocumentText = WriteHTML.ExportDatatableToHtml(CreateCrozzle.dt);
            }
            catch (Exception ex)
            {
                LogFile.WriteLogFile("Error Entry : ----Exception----" + ex.Message);
                //LogFile.WriteErrorFile("Error Entry : ----Exception----" + ex.Message);
            }
        }

        private void saveCrozzle_Click(object sender, EventArgs e)
        {
            try
            {
                LogFile.WriteLogFile("Start Save Crozzle File");
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Crozzle Save File Dialog";
                // inital path
                //fdlg.InitialDirectory = Application.StartupPath;
                //fdlg.InitialDirectory = Environment.CurrentDirectory;
                // filters the file 
                sfd.Filter = "TXT Files(*.txt)|*.txt|All Files(*.*)|*.*";
                sfd.FilterIndex = 1;
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string localFilePath = sfd.FileName.ToString();
                    string fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1);

                    FileStream fs = File.Open(sfd.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);

                    int count = 0;

                    sw.WriteLine(DataLoad.TCFL);
                    foreach (TestCrozzleSecondLine tcsl in DataLoad.TCSL)
                    {

                        if (count == DataLoad.TCSL.Count - 1)
                            sw.WriteLine(tcsl.wordlist);
                        else
                            sw.Write(tcsl.wordlist + ",");
                        count++;
                    }

                    foreach (HorizontalWordForExport hwfe in CreateCrozzle.HWFE)
                    {
                        string path = "HORIZONTAL";

                        sw.WriteLine("{0},{1},{2},{3}", path, hwfe.IX, hwfe.IY, hwfe.wholeword);
                    }
                    foreach (VerticalWordForExport vwfe in CreateCrozzle.VWFE)
                    {
                        string path = "VERTICAL";

                        sw.WriteLine("{0},{1},{2},{3}", path, vwfe.IX, vwfe.IY, vwfe.wholeword);
                    }
                    //close file
                    sw.Flush();
                    sw.Close();
                    fs.Close();

                    MessageBox.Show("Save Success" + sfd.FileName);

                }
            }
            catch (Exception ex)
            {
                LogFile.WriteLogFile("Error Entry : ----Exception----" + ex.Message);
                //LogFile.WriteErrorFile("Error Entry : ----Exception----" + e.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void saveCrozzleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LogFile.WriteLogFile("Start Save Crozzle File");
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Crozzle Save File Dialog";
                // inital path
                //fdlg.InitialDirectory = Application.StartupPath;
                //fdlg.InitialDirectory = Environment.CurrentDirectory;
                // filters the file 
                sfd.Filter = "TXT Files(*.txt)|*.txt|All Files(*.*)|*.*";
                sfd.FilterIndex = 1;
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string localFilePath = sfd.FileName.ToString();
                    string fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1);

                    FileStream fs = File.Open(sfd.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);

                    int count = 0;

                    sw.WriteLine(DataLoad.TCFL);
                    foreach (TestCrozzleSecondLine tcsl in DataLoad.TCSL)
                    {

                        if (count == DataLoad.TCSL.Count - 1)
                            sw.WriteLine(tcsl.wordlist);
                        else
                            sw.Write(tcsl.wordlist + ",");
                        count++;
                    }

                    foreach (HorizontalWordForExport hwfe in CreateCrozzle.HWFE)
                    {
                        string path = "HORIZONTAL";

                        sw.WriteLine("{0},{1},{2},{3}", path, hwfe.IX, hwfe.IY, hwfe.wholeword);
                    }
                    foreach (VerticalWordForExport vwfe in CreateCrozzle.VWFE)
                    {
                        string path = "VERTICAL";

                        sw.WriteLine("{0},{1},{2},{3}", path, vwfe.IX, vwfe.IY, vwfe.wholeword);
                    }
                    //close file
                    sw.Flush();
                    sw.Close();
                    fs.Close();

                    MessageBox.Show("Save Success" + sfd.FileName);

                }
            }
            catch (Exception ex)
            {
                LogFile.WriteLogFile("Error Entry : ----Exception----" + ex.Message);
                //LogFile.WriteErrorFile("Error Entry : ----Exception----" + e.Message);
            }

        }
    }
}

