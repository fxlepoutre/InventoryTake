namespace InventoryTake
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartCount = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtWorkID = new System.Windows.Forms.TextBox();
            this.lbWorkID = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelListBox1 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartTransfer = new System.Windows.Forms.Button();
            this.btnStartPick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartCount
            // 
            this.btnStartCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
            this.btnStartCount.Location = new System.Drawing.Point(124, 82);
            this.btnStartCount.Name = "btnStartCount";
            this.btnStartCount.Size = new System.Drawing.Size(102, 30);
            this.btnStartCount.TabIndex = 33;
            this.btnStartCount.Text = "Count";
            this.btnStartCount.Click += new System.EventHandler(this.btnStartCount_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
            this.btnExit.Location = new System.Drawing.Point(124, 237);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 30);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtWorkID
            // 
            this.txtWorkID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
            this.txtWorkID.Location = new System.Drawing.Point(89, 17);
            this.txtWorkID.Name = "txtWorkID";
            this.txtWorkID.Size = new System.Drawing.Size(137, 23);
            this.txtWorkID.TabIndex = 31;
            // 
            // lbWorkID
            // 
            this.lbWorkID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
            this.lbWorkID.Location = new System.Drawing.Point(21, 20);
            this.lbWorkID.Name = "lbWorkID";
            this.lbWorkID.Size = new System.Drawing.Size(62, 20);
            this.lbWorkID.TabIndex = 34;
            this.lbWorkID.Text = "Work ID:";
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(16, 148);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 69);
            this.listBox1.TabIndex = 25;
            // 
            // labelListBox1
            // 
            this.labelListBox1.Location = new System.Drawing.Point(13, 132);
            this.labelListBox1.Name = "labelListBox1";
            this.labelListBox1.Size = new System.Drawing.Size(105, 13);
            this.labelListBox1.TabIndex = 35;
            this.labelListBox1.Text = "Files on device:";
            // 
            // btnUpload
            // 
            this.btnUpload.Enabled = false;
            this.btnUpload.Location = new System.Drawing.Point(16, 237);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(102, 30);
            this.btnUpload.TabIndex = 36;
            this.btnUpload.Text = "Upload files";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(14, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 14);
            this.label1.TabIndex = 37;
            this.label1.Text = "Destination: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStartTransfer
            // 
            this.btnStartTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
            this.btnStartTransfer.Location = new System.Drawing.Point(124, 46);
            this.btnStartTransfer.Name = "btnStartTransfer";
            this.btnStartTransfer.Size = new System.Drawing.Size(102, 30);
            this.btnStartTransfer.TabIndex = 38;
            this.btnStartTransfer.Text = "Transfer";
            this.btnStartTransfer.Click += new System.EventHandler(this.btnStartTransfer_Click);
            // 
            // btnStartPick
            // 
            this.btnStartPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
            this.btnStartPick.Location = new System.Drawing.Point(15, 46);
            this.btnStartPick.Name = "btnStartPick";
            this.btnStartPick.Size = new System.Drawing.Size(102, 30);
            this.btnStartPick.TabIndex = 39;
            this.btnStartPick.Text = "Pick";
            this.btnStartPick.Click += new System.EventHandler(this.btnStartPick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(241, 273);
            this.ControlBox = false;
            this.Controls.Add(this.btnStartPick);
            this.Controls.Add(this.btnStartTransfer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.labelListBox1);
            this.Controls.Add(this.btnStartCount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtWorkID);
            this.Controls.Add(this.lbWorkID);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Inventory Take";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartCount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtWorkID;
        private System.Windows.Forms.Label lbWorkID;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelListBox1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartTransfer;
        private System.Windows.Forms.Button btnStartPick;
    }
}

