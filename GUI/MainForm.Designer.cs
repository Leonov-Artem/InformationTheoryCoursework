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
            this.crcResultLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.computeCRCButton = new System.Windows.Forms.Button();
            this.bitGenPolynomLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bitStringLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.generatingPolynomTextBox = new System.Windows.Forms.TextBox();
            this.hexMessageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.remainderLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.computeRemainderButton = new System.Windows.Forms.Button();
            this.CrcTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.copyDataButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.bitGenPolyTextBox = new System.Windows.Forms.TextBox();
            this.bitStringTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CRCgroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.CRCgroupBox.Controls.Add(this.crcResultLabel);
            this.CRCgroupBox.Controls.Add(this.label5);
            this.CRCgroupBox.Controls.Add(this.computeCRCButton);
            this.CRCgroupBox.Controls.Add(this.bitGenPolynomLabel);
            this.CRCgroupBox.Controls.Add(this.label4);
            this.CRCgroupBox.Controls.Add(this.bitStringLabel);
            this.CRCgroupBox.Controls.Add(this.label3);
            this.CRCgroupBox.Controls.Add(this.generatingPolynomTextBox);
            this.CRCgroupBox.Controls.Add(this.hexMessageTextBox);
            this.CRCgroupBox.Controls.Add(this.label2);
            this.CRCgroupBox.Controls.Add(this.label1);
            this.CRCgroupBox.Location = new System.Drawing.Point(348, 13);
            this.CRCgroupBox.Name = "CRCgroupBox";
            this.CRCgroupBox.Size = new System.Drawing.Size(298, 425);
            this.CRCgroupBox.TabIndex = 1;
            this.CRCgroupBox.TabStop = false;
            this.CRCgroupBox.Text = "CRC - код";
            // 
            // crcResultLabel
            // 
            this.crcResultLabel.AutoSize = true;
            this.crcResultLabel.Location = new System.Drawing.Point(10, 349);
            this.crcResultLabel.Name = "crcResultLabel";
            this.crcResultLabel.Size = new System.Drawing.Size(13, 13);
            this.crcResultLabel.TabIndex = 10;
            this.crcResultLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Вычисленный CRC - код:";
            // 
            // computeCRCButton
            // 
            this.computeCRCButton.Location = new System.Drawing.Point(10, 267);
            this.computeCRCButton.Name = "computeCRCButton";
            this.computeCRCButton.Size = new System.Drawing.Size(277, 36);
            this.computeCRCButton.TabIndex = 8;
            this.computeCRCButton.Text = "Вычислить CRC - код";
            this.computeCRCButton.UseVisualStyleBackColor = true;
            this.computeCRCButton.Click += new System.EventHandler(this.ComputeCRCButton_Click);
            // 
            // bitGenPolynomLabel
            // 
            this.bitGenPolynomLabel.AutoSize = true;
            this.bitGenPolynomLabel.Location = new System.Drawing.Point(12, 239);
            this.bitGenPolynomLabel.Name = "bitGenPolynomLabel";
            this.bitGenPolynomLabel.Size = new System.Drawing.Size(13, 13);
            this.bitGenPolynomLabel.TabIndex = 7;
            this.bitGenPolynomLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "В двоичной системе:";
            // 
            // bitStringLabel
            // 
            this.bitStringLabel.AutoSize = true;
            this.bitStringLabel.Location = new System.Drawing.Point(12, 108);
            this.bitStringLabel.Name = "bitStringLabel";
            this.bitStringLabel.Size = new System.Drawing.Size(13, 13);
            this.bitStringLabel.TabIndex = 5;
            this.bitStringLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "В двоичной системе:";
            // 
            // generatingPolynomTextBox
            // 
            this.generatingPolynomTextBox.Location = new System.Drawing.Point(10, 173);
            this.generatingPolynomTextBox.Name = "generatingPolynomTextBox";
            this.generatingPolynomTextBox.Size = new System.Drawing.Size(277, 20);
            this.generatingPolynomTextBox.TabIndex = 3;
            // 
            // hexMessageTextBox
            // 
            this.hexMessageTextBox.Location = new System.Drawing.Point(10, 48);
            this.hexMessageTextBox.Name = "hexMessageTextBox";
            this.hexMessageTextBox.Size = new System.Drawing.Size(277, 20);
            this.hexMessageTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Порождающий полином:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Последовательность символов:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.remainderLabel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.computeRemainderButton);
            this.groupBox1.Controls.Add(this.CrcTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.copyDataButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.bitGenPolyTextBox);
            this.groupBox1.Controls.Add(this.bitStringTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(663, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 420);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Контрольная сумма";
            // 
            // remainderLabel
            // 
            this.remainderLabel.AutoSize = true;
            this.remainderLabel.Location = new System.Drawing.Point(10, 349);
            this.remainderLabel.Name = "remainderLabel";
            this.remainderLabel.Size = new System.Drawing.Size(0, 13);
            this.remainderLabel.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Вычисленный остаток:";
            // 
            // computeRemainderButton
            // 
            this.computeRemainderButton.Location = new System.Drawing.Point(10, 267);
            this.computeRemainderButton.Name = "computeRemainderButton";
            this.computeRemainderButton.Size = new System.Drawing.Size(282, 36);
            this.computeRemainderButton.TabIndex = 7;
            this.computeRemainderButton.Text = "Вычислить остаток";
            this.computeRemainderButton.UseVisualStyleBackColor = true;
            this.computeRemainderButton.Click += new System.EventHandler(this.ComputeRemainderButton_Click);
            // 
            // CrcTextBox
            // 
            this.CrcTextBox.Location = new System.Drawing.Point(10, 173);
            this.CrcTextBox.Name = "CrcTextBox";
            this.CrcTextBox.Size = new System.Drawing.Size(282, 20);
            this.CrcTextBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "CRC  - код:";
            // 
            // copyDataButton
            // 
            this.copyDataButton.Location = new System.Drawing.Point(10, 210);
            this.copyDataButton.Name = "copyDataButton";
            this.copyDataButton.Size = new System.Drawing.Size(282, 36);
            this.copyDataButton.TabIndex = 4;
            this.copyDataButton.Text = "Скопировать данные из предыдущей группы";
            this.copyDataButton.UseVisualStyleBackColor = true;
            this.copyDataButton.Click += new System.EventHandler(this.CopyDataButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Порождающий полином (в двоичной системе):";
            // 
            // bitGenPolyTextBox
            // 
            this.bitGenPolyTextBox.Location = new System.Drawing.Point(6, 108);
            this.bitGenPolyTextBox.Name = "bitGenPolyTextBox";
            this.bitGenPolyTextBox.Size = new System.Drawing.Size(286, 20);
            this.bitGenPolyTextBox.TabIndex = 2;
            // 
            // bitStringTextBox
            // 
            this.bitStringTextBox.Location = new System.Drawing.Point(7, 47);
            this.bitStringTextBox.Name = "bitStringTextBox";
            this.bitStringTextBox.Size = new System.Drawing.Size(285, 20);
            this.bitStringTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Последовательность (в двоичной системе):";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CRCgroupBox);
            this.Controls.Add(this.huffmanGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кодирование информации";
            this.CRCgroupBox.ResumeLayout(false);
            this.CRCgroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox huffmanGroupBox;
        private System.Windows.Forms.GroupBox CRCgroupBox;
        private System.Windows.Forms.Label crcResultLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button computeCRCButton;
        private System.Windows.Forms.Label bitGenPolynomLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bitStringLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox generatingPolynomTextBox;
        private System.Windows.Forms.TextBox hexMessageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CrcTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button copyDataButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bitGenPolyTextBox;
        private System.Windows.Forms.TextBox bitStringTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label remainderLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button computeRemainderButton;
    }
}

