namespace GUI
{
    partial class MainForm
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
            this.huffmanGroupBox = new System.Windows.Forms.GroupBox();
            this.CRCgroupBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // huffmanGroupBox
            // 
            this.huffmanGroupBox.Location = new System.Drawing.Point(13, 13);
            this.huffmanGroupBox.Name = "huffmanGroupBox";
            this.huffmanGroupBox.Size = new System.Drawing.Size(329, 338);
            this.huffmanGroupBox.TabIndex = 0;
            this.huffmanGroupBox.TabStop = false;
            this.huffmanGroupBox.Text = "Код Хаффмана";
            // 
            // CRCgroupBox
            // 
            this.CRCgroupBox.Location = new System.Drawing.Point(466, 13);
            this.CRCgroupBox.Name = "CRCgroupBox";
            this.CRCgroupBox.Size = new System.Drawing.Size(322, 338);
            this.CRCgroupBox.TabIndex = 1;
            this.CRCgroupBox.TabStop = false;
            this.CRCgroupBox.Text = "CRC - код";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRCgroupBox);
            this.Controls.Add(this.huffmanGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кодирование информации";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox huffmanGroupBox;
        private System.Windows.Forms.GroupBox CRCgroupBox;
    }
}

