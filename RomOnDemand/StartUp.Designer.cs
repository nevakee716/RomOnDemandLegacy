namespace RomOnDemand
{
    partial class StartUp
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxSelected = new System.Windows.Forms.PictureBox();
            this.consoleCoverList = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSelected
            // 
            this.pictureBoxSelected.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSelected.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxSelected.Name = "pictureBoxSelected";
            this.pictureBoxSelected.Size = new System.Drawing.Size(241, 358);
            this.pictureBoxSelected.TabIndex = 3;
            this.pictureBoxSelected.TabStop = false;
            // 
            // consoleCoverList
            // 
            this.consoleCoverList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.consoleCoverList.ImageSize = new System.Drawing.Size(256, 256);
            this.consoleCoverList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(343, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 252);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1149, 476);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StartUp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnLoadStartup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList consoleCoverList;
        private System.Windows.Forms.PictureBox pictureBoxSelected;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

