namespace Mausometer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelKM = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.labelCM = new System.Windows.Forms.Label();
            this.labelLEFT = new System.Windows.Forms.Label();
            this.labelMIDDLE = new System.Windows.Forms.Label();
            this.labelRIGHT = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.PercLEFT = new System.Windows.Forms.Label();
            this.PercMIDDLE = new System.Windows.Forms.Label();
            this.PercRIGHT = new System.Windows.Forms.Label();
            this.labelUP = new System.Windows.Forms.Label();
            this.labelDOWN = new System.Windows.Forms.Label();
            this.labelABS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelDestination = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Progressbarlabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LastResetlabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelKM
            // 
            this.labelKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelKM.ForeColor = System.Drawing.Color.White;
            this.labelKM.Location = new System.Drawing.Point(38, 20);
            this.labelKM.Name = "labelKM";
            this.labelKM.Size = new System.Drawing.Size(99, 44);
            this.labelKM.TabIndex = 2;
            this.labelKM.Text = "9999 km";
            this.labelKM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelM
            // 
            this.labelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelM.ForeColor = System.Drawing.Color.White;
            this.labelM.Location = new System.Drawing.Point(26, 53);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(102, 44);
            this.labelM.TabIndex = 3;
            this.labelM.Text = "999 m";
            this.labelM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCM
            // 
            this.labelCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelCM.ForeColor = System.Drawing.Color.White;
            this.labelCM.Location = new System.Drawing.Point(31, 89);
            this.labelCM.Name = "labelCM";
            this.labelCM.Size = new System.Drawing.Size(104, 44);
            this.labelCM.TabIndex = 4;
            this.labelCM.Text = "99 cm";
            this.labelCM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLEFT
            // 
            this.labelLEFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLEFT.ForeColor = System.Drawing.Color.White;
            this.labelLEFT.Location = new System.Drawing.Point(18, 169);
            this.labelLEFT.Name = "labelLEFT";
            this.labelLEFT.Size = new System.Drawing.Size(73, 34);
            this.labelLEFT.TabIndex = 5;
            this.labelLEFT.Text = "0";
            this.labelLEFT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMIDDLE
            // 
            this.labelMIDDLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMIDDLE.ForeColor = System.Drawing.Color.White;
            this.labelMIDDLE.Location = new System.Drawing.Point(106, 169);
            this.labelMIDDLE.Name = "labelMIDDLE";
            this.labelMIDDLE.Size = new System.Drawing.Size(70, 34);
            this.labelMIDDLE.TabIndex = 6;
            this.labelMIDDLE.Text = "0";
            this.labelMIDDLE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRIGHT
            // 
            this.labelRIGHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRIGHT.ForeColor = System.Drawing.Color.White;
            this.labelRIGHT.Location = new System.Drawing.Point(176, 169);
            this.labelRIGHT.Name = "labelRIGHT";
            this.labelRIGHT.Size = new System.Drawing.Size(82, 34);
            this.labelRIGHT.TabIndex = 7;
            this.labelRIGHT.Text = "0";
            this.labelRIGHT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick_1);
            // 
            // PercLEFT
            // 
            this.PercLEFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercLEFT.ForeColor = System.Drawing.Color.Black;
            this.PercLEFT.Location = new System.Drawing.Point(24, 196);
            this.PercLEFT.Name = "PercLEFT";
            this.PercLEFT.Size = new System.Drawing.Size(71, 34);
            this.PercLEFT.TabIndex = 9;
            this.PercLEFT.Text = "0 %";
            this.PercLEFT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PercMIDDLE
            // 
            this.PercMIDDLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercMIDDLE.ForeColor = System.Drawing.Color.Black;
            this.PercMIDDLE.Location = new System.Drawing.Point(109, 196);
            this.PercMIDDLE.Name = "PercMIDDLE";
            this.PercMIDDLE.Size = new System.Drawing.Size(71, 34);
            this.PercMIDDLE.TabIndex = 10;
            this.PercMIDDLE.Text = "0 %";
            this.PercMIDDLE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PercRIGHT
            // 
            this.PercRIGHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercRIGHT.ForeColor = System.Drawing.Color.Black;
            this.PercRIGHT.Location = new System.Drawing.Point(180, 42);
            this.PercRIGHT.Name = "PercRIGHT";
            this.PercRIGHT.Size = new System.Drawing.Size(67, 34);
            this.PercRIGHT.TabIndex = 11;
            this.PercRIGHT.Text = "0 %";
            this.PercRIGHT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelUP
            // 
            this.labelUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelUP.ForeColor = System.Drawing.Color.White;
            this.labelUP.Location = new System.Drawing.Point(223, 27);
            this.labelUP.Name = "labelUP";
            this.labelUP.Size = new System.Drawing.Size(62, 34);
            this.labelUP.TabIndex = 12;
            this.labelUP.Text = "99999";
            this.labelUP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDOWN
            // 
            this.labelDOWN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelDOWN.ForeColor = System.Drawing.Color.White;
            this.labelDOWN.Location = new System.Drawing.Point(226, 57);
            this.labelDOWN.Name = "labelDOWN";
            this.labelDOWN.Size = new System.Drawing.Size(59, 34);
            this.labelDOWN.TabIndex = 13;
            this.labelDOWN.Text = "99999";
            this.labelDOWN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelABS
            // 
            this.labelABS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelABS.ForeColor = System.Drawing.Color.White;
            this.labelABS.Location = new System.Drawing.Point(225, 94);
            this.labelABS.Name = "labelABS";
            this.labelABS.Size = new System.Drawing.Size(59, 34);
            this.labelABS.TabIndex = 14;
            this.labelABS.Text = "9999";
            this.labelABS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(222, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "↑";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(222, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "↓";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(222, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Σ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(45, 258);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar1.Size = new System.Drawing.Size(230, 5);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Value = 30;
            // 
            // labelDestination
            // 
            this.labelDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestination.Location = new System.Drawing.Point(277, 246);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(58, 29);
            this.labelDestination.TabIndex = 20;
            this.labelDestination.Text = "New York";
            this.labelDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(8, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "MUC";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 140);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tacho";
            // 
            // groupBox2
            // 
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(189, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 140);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mausrad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PercRIGHT);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(15, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 82);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mausklicks";
            // 
            // Progressbarlabel
            // 
            this.Progressbarlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Progressbarlabel.Location = new System.Drawing.Point(97, 266);
            this.Progressbarlabel.Name = "Progressbarlabel";
            this.Progressbarlabel.Size = new System.Drawing.Size(141, 20);
            this.Progressbarlabel.TabIndex = 24;
            this.Progressbarlabel.Text = "0 % ";
            this.Progressbarlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstellungenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 26);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // LastResetlabel
            // 
            this.LastResetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastResetlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.LastResetlabel.Location = new System.Drawing.Point(-2, 291);
            this.LastResetlabel.Name = "LastResetlabel";
            this.LastResetlabel.Size = new System.Drawing.Size(337, 29);
            this.LastResetlabel.TabIndex = 26;
            this.LastResetlabel.Text = "Letzer Reset am: 01.05.2020 14:20 Uhr";
            this.LastResetlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LastResetlabel.Click += new System.EventHandler(this.LastResetlabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(347, 317);
            this.Controls.Add(this.LastResetlabel);
            this.Controls.Add(this.Progressbarlabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelABS);
            this.Controls.Add(this.labelDOWN);
            this.Controls.Add(this.labelUP);
            this.Controls.Add(this.PercMIDDLE);
            this.Controls.Add(this.PercLEFT);
            this.Controls.Add(this.labelRIGHT);
            this.Controls.Add(this.labelMIDDLE);
            this.Controls.Add(this.labelLEFT);
            this.Controls.Add(this.labelCM);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.labelKM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.Text = "Maus-O-Meter";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelKM;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelCM;
        private System.Windows.Forms.Label labelLEFT;
        private System.Windows.Forms.Label labelMIDDLE;
        private System.Windows.Forms.Label labelRIGHT;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label PercLEFT;
        private System.Windows.Forms.Label PercMIDDLE;
        private System.Windows.Forms.Label PercRIGHT;
        private System.Windows.Forms.Label labelUP;
        private System.Windows.Forms.Label labelDOWN;
        private System.Windows.Forms.Label labelABS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Progressbarlabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.Label LastResetlabel;
    }
}

