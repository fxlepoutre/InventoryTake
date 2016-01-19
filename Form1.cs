using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Intermec.DataCollection;

namespace InventoryTake
{
    public partial class Form1 : Form
    {
        private String strDataDirectory = @"\Sophie\Data\";
        private String strUploadDirectory = @"\\storage\Public\Aplikasi\InventoryTake\";
        //declare SymbologyOptions object
        private Intermec.DataCollection.SymbologyOptions symbOptions;
        private String strDefaultPostamble;

        public Form1()
        {
            InitializeComponent();
            this.loadFileNamesInListBox();
            this.label1.Text = "Destination: " + strUploadDirectory;
            this.txtWorkID.Focus();
            try
            {
                //create a instance of SymbologyOptions class
                symbOptions = new Intermec.DataCollection.SymbologyOptions();
                //enable symbology options exceptions
                symbOptions.EnableSymbologyOptionsExceptions(true);
                strDefaultPostamble = this.symbOptions.Postamble.ToString();
                this.symbOptions.Postamble = @"\t";
            }
            catch (SymbologyOptionsException SymbOpXp)
            {
                MessageBox.Show(SymbOpXp.Message);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        public void loadFileNamesInListBox() {
            if (!Directory.Exists(strDataDirectory)) Directory.CreateDirectory(strDataDirectory);
            String[] fileEntries = Directory.GetFiles(strDataDirectory);
            this.listBox1.Items.Clear();
            foreach (String fileName in fileEntries)
                this.listBox1.Items.Add(fileName.Remove(0, strDataDirectory.Length));
            if (fileEntries.Length != 0)
                this.btnUpload.Enabled = true;
        }

        private void btnStartCount_Click(object sender, EventArgs e)
        {
            // Generate file name
            try
            {
                String strFileName = strDataDirectory + System.Net.Dns.GetHostName() + "-Count-" + DateTime.Now.ToString("yyyyMMddHHmmss") + ((this.txtWorkID.Text.Length != 0) ? "-" : "") + this.txtWorkID.Text.ToString() + ".csv";
                // Open Form 2
                using (Form2Count f2count = new Form2Count(strFileName))
                {
                    f2count.ShowDialog();
                    this.loadFileNamesInListBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot generate file name and launch app.\n" + ex.Message );
            }
        }

        private void btnStartTransfer_Click(object sender, EventArgs e)
        {
            // Generate file name
            try
            {
                String strFileName = strDataDirectory + System.Net.Dns.GetHostName() + "-Transfer-" + DateTime.Now.ToString("yyyyMMddHHmmss") + ((this.txtWorkID.Text.Length != 0) ? "-" : "") + this.txtWorkID.Text.ToString() + ".csv";
                // Open Form 2
                using (Form2Transfer f2transfer = new Form2Transfer(strFileName))
                {
                    f2transfer.ShowDialog();
                    this.loadFileNamesInListBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot generate file name and launch app.\n" + ex.Message);
            }
        }

        private void btnStartPick_Click(object sender, EventArgs e)
        {
            // Generate file name
            try
            {
                String strFileName = strDataDirectory + System.Net.Dns.GetHostName() + "-Pick-" + DateTime.Now.ToString("yyyyMMddHHmmss") + ((this.txtWorkID.Text.Length != 0) ? "-" : "") + this.txtWorkID.Text.ToString() + ".csv";
                // Open Form 2
                using (Form2Pick f2pick = new Form2Pick(strFileName))
                {
                    f2pick.ShowDialog();
                    this.loadFileNamesInListBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot generate file name and launch app.\n" + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.symbOptions.Postamble = strDefaultPostamble;
                this.symbOptions.Dispose();
            }
            catch (SymbologyOptionsException SymbOpXp)
            {
                MessageBox.Show(SymbOpXp.Message);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            Application.Exit();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            this.btnUpload.Enabled = false;
            this.btnUpload.Text = "Uploading...";
            String[] fileEntries = Directory.GetFiles(strDataDirectory);
            String fileName2;
            foreach (String fileName in fileEntries) {
                try
                {
                    if (fileName.Contains("-Count-"))
                        fileName2 = strUploadDirectory + @"UploadCount\" + fileName.Remove(0, strDataDirectory.Length);
                    else if (fileName.Contains("-Transfer-"))
                        fileName2 = strUploadDirectory + @"UploadTransfer\" + fileName.Remove(0, strDataDirectory.Length);
                    else if (fileName.Contains("-Pick-"))
                        fileName2 = strUploadDirectory + @"UploadPick\" + fileName.Remove(0, strDataDirectory.Length);
                    else
                        fileName2 = strUploadDirectory + fileName.Remove(0, strDataDirectory.Length);
                    if (File.Exists(fileName2)) fileName2 = fileName2.Replace(".csv", "-retry" + DateTime.Now.ToString("ddHHmmss") + ".csv");
                    File.Move(fileName, fileName2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File \'" + fileName + "\' is pending, but the upload process failed. Check with your admin to resolve.\n" + ex.Message);
                    break;
                }
            }
            this.loadFileNamesInListBox();
            this.btnUpload.Text = "Upload files";
        }
    }
}