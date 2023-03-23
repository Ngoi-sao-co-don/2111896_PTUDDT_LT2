namespace StatusStrip_OpenFileDialog
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("C:\\Users\\FPT-PC\\Desktop\\2111896_NguyenTanTien_BuoiLyThuyetSo2\\img\\1.jpg");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("C:\\Users\\FPT-PC\\Desktop\\2111896_NguyenTanTien_BuoiLyThuyetSo2\\img\\2.jpg");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("C:\\Users\\FPT-PC\\Desktop\\2111896_NguyenTanTien_BuoiLyThuyetSo2\\img\\3.jpg");
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lvListFile = new System.Windows.Forms.ListView();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.statusStripFileName = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.statusStripFileName.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(13, 13);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(92, 29);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(142, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(271, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lvListFile
            // 
            this.lvListFile.HideSelection = false;
            this.lvListFile.ImeMode = System.Windows.Forms.ImeMode.Disable;
            listViewItem1.StateImageIndex = 0;
            this.lvListFile.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvListFile.Location = new System.Drawing.Point(13, 71);
            this.lvListFile.Name = "lvListFile";
            this.lvListFile.Size = new System.Drawing.Size(422, 447);
            this.lvListFile.TabIndex = 1;
            this.lvListFile.TileSize = new System.Drawing.Size(1, 1);
            this.lvListFile.UseCompatibleStateImageBehavior = false;
            this.lvListFile.View = System.Windows.Forms.View.SmallIcon;
            this.lvListFile.SelectedIndexChanged += new System.EventHandler(this.lvListFile_SelectedIndexChanged);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(463, 71);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(461, 447);
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            // 
            // statusStripFileName
            // 
            this.statusStripFileName.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripFileName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripFileName.Location = new System.Drawing.Point(0, 532);
            this.statusStripFileName.Name = "statusStripFileName";
            this.statusStripFileName.Size = new System.Drawing.Size(936, 26);
            this.statusStripFileName.TabIndex = 3;
            this.statusStripFileName.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 558);
            this.Controls.Add(this.statusStripFileName);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lvListFile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Ví dụ minh họa về StatusStrip, OpenDialog";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.statusStripFileName.ResumeLayout(false);
            this.statusStripFileName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView lvListFile;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.StatusStrip statusStripFileName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

