namespace PortScannerApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPorts = new System.Windows.Forms.TextBox();
            this.scanButton = new System.Windows.Forms.Button();
            this.scannedPortsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Andalus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "PortScannerApp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Andalus", 13F);
            this.label2.Location = new System.Drawing.Point(23, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the Port Range";
            // 
            // txtBoxPorts
            // 
            this.txtBoxPorts.Font = new System.Drawing.Font("Andalus", 13F);
            this.txtBoxPorts.Location = new System.Drawing.Point(203, 192);
            this.txtBoxPorts.Name = "txtBoxPorts";
            this.txtBoxPorts.Size = new System.Drawing.Size(258, 34);
            this.txtBoxPorts.TabIndex = 2;
            // 
            // scanButton
            // 
            this.scanButton.Font = new System.Drawing.Font("Andalus", 13F);
            this.scanButton.Location = new System.Drawing.Point(317, 273);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(144, 40);
            this.scanButton.TabIndex = 3;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // scannedPortsListBox
            // 
            this.scannedPortsListBox.BackColor = System.Drawing.SystemColors.Window;
            this.scannedPortsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scannedPortsListBox.FormattingEnabled = true;
            this.scannedPortsListBox.Location = new System.Drawing.Point(515, 148);
            this.scannedPortsListBox.Name = "scannedPortsListBox";
            this.scannedPortsListBox.Size = new System.Drawing.Size(366, 275);
            this.scannedPortsListBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Andalus", 13F);
            this.label3.Location = new System.Drawing.Point(510, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Scanned port Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 447);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scannedPortsListBox);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.txtBoxPorts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPorts;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.ListBox scannedPortsListBox;
        private System.Windows.Forms.Label label3;
    }
}

