using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace InventoryTake
{
    public partial class Form2Pick : Form
    {

        private String strFileName = String.Empty;

        public Form2Pick(String strInputFileName)
        {
            InitializeComponent();
            strFileName = strInputFileName;
            this.textBox2.Focus();
        }

        private void fnWriteToFile(String strInputFileName, String strInputNewLine )
        {
            // If the File does not exist, create it
            if (!File.Exists(strInputFileName))
            {
                File.Create(strInputFileName).Close();
                fnWriteToFile(strInputFileName, "pallet_id;sku;qty;timestamp" + Environment.NewLine);
            }

            StreamWriter swFile =
                         new StreamWriter(
                            new FileStream(strInputFileName,
                                           FileMode.Append),
                            Encoding.UTF8);

            swFile.Write(strInputNewLine);
            swFile.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = String.Empty;
            this.textBox3.Text = String.Empty;
            this.textBox4.Text = String.Empty;
            this.textBox2.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Save data to file
            String strNewLine = this.textBox2.Text + ";" + this.textBox3.Text + ";" + this.textBox4.Text + ";" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + Environment.NewLine;
            fnWriteToFile(strFileName, strNewLine);
            // Close Window
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Save data to file
            String strNewLine = this.textBox2.Text + ";" + this.textBox3.Text + ";" + this.textBox4.Text + ";" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + Environment.NewLine;
            fnWriteToFile(strFileName, strNewLine);

            // Clear fields
            this.button3_Click(this.button3, EventArgs.Empty);
        }
    }
}