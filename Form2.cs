using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace InventoryTake
{
    public partial class Form2 : Form
    {

        private String strFileName = String.Empty;
        
        public Form2(String strInputFileName)
        {
            InitializeComponent();
            strFileName = strInputFileName;
            this.textBox1.Focus();
        }

        private void fnWriteToFile(String strInputFileName, String strInputNewLine )
        {
            // If the File does not exist, create it
            if (!File.Exists(strInputFileName))
            {
                File.Create(strInputFileName).Close();
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
            this.textBox1.Text = String.Empty;
            this.textBox2.Text = String.Empty;
            this.textBox3.Text = String.Empty;
            this.textBox4.Text = String.Empty;
            this.textBox5.Text = String.Empty;
            this.textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Save data to file
            String strNewLine = this.textBox1.Text + ";" + this.textBox2.Text + ";" + this.textBox3.Text + ";" + this.textBox4.Text + ";" + this.textBox5.Text + ";" + Environment.NewLine;
            fnWriteToFile(strFileName, strNewLine);
            // Close Window
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Save data to file
            String strNewLine = this.textBox1.Text + ";" + this.textBox2.Text + ";" + this.textBox3.Text + ";" + this.textBox4.Text + ";" + this.textBox5.Text + ";" + Environment.NewLine;
            fnWriteToFile(strFileName, strNewLine);

            // Clear fields
            this.button3_Click(this.button3, EventArgs.Empty);
        }

    }
}