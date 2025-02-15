namespace Nvision
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmdSERIAL = new System.Windows.Forms.Label();
            this.runSFC = new System.Windows.Forms.Button();
            this.runDISM = new System.Windows.Forms.Button();
            this.cmdMEM = new System.Windows.Forms.Label();
            this.cmdMEMslots = new System.Windows.Forms.Label();
            this.cmdMEMavailable = new System.Windows.Forms.Label();
            this.runPING = new System.Windows.Forms.Button();
            this.cpuTEMP = new System.Windows.Forms.Label();
            this.tempTimer = new System.Windows.Forms.Timer(this.components);
            this.gpuTEMP = new System.Windows.Forms.Label();
            this.cmdMOBO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdBATTERY = new System.Windows.Forms.Label();
            this.cmdSMART = new System.Windows.Forms.Label();
            this.cmdBIOSVER = new System.Windows.Forms.Label();
            this.cmdMEMSPEED = new System.Windows.Forms.Label();
            this.cmdMEMCAPACITY = new System.Windows.Forms.Label();
            this.sourceCODE = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdSERIAL
            // 
            this.cmdSERIAL.AutoSize = true;
            this.cmdSERIAL.BackColor = System.Drawing.Color.Transparent;
            this.cmdSERIAL.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSERIAL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdSERIAL.Location = new System.Drawing.Point(20, 123);
            this.cmdSERIAL.Name = "cmdSERIAL";
            this.cmdSERIAL.Size = new System.Drawing.Size(298, 35);
            this.cmdSERIAL.TabIndex = 0;
            this.cmdSERIAL.Text = "Placeholder Serial";
            this.cmdSERIAL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // runSFC
            // 
            this.runSFC.BackColor = System.Drawing.Color.Black;
            this.runSFC.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runSFC.ForeColor = System.Drawing.Color.Fuchsia;
            this.runSFC.Location = new System.Drawing.Point(12, 660);
            this.runSFC.Name = "runSFC";
            this.runSFC.Size = new System.Drawing.Size(270, 50);
            this.runSFC.TabIndex = 1;
            this.runSFC.Text = "SFC";
            this.runSFC.UseVisualStyleBackColor = false;
            this.runSFC.Click += new System.EventHandler(this.runSFC_Click);
            // 
            // runDISM
            // 
            this.runDISM.BackColor = System.Drawing.Color.Black;
            this.runDISM.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runDISM.ForeColor = System.Drawing.Color.Fuchsia;
            this.runDISM.Location = new System.Drawing.Point(12, 716);
            this.runDISM.Name = "runDISM";
            this.runDISM.Size = new System.Drawing.Size(270, 50);
            this.runDISM.TabIndex = 2;
            this.runDISM.Text = "DISM";
            this.runDISM.UseVisualStyleBackColor = false;
            this.runDISM.Click += new System.EventHandler(this.runDISM_Click);
            // 
            // cmdMEM
            // 
            this.cmdMEM.AutoSize = true;
            this.cmdMEM.BackColor = System.Drawing.Color.Transparent;
            this.cmdMEM.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMEM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdMEM.Location = new System.Drawing.Point(550, 222);
            this.cmdMEM.Name = "cmdMEM";
            this.cmdMEM.Size = new System.Drawing.Size(407, 35);
            this.cmdMEM.TabIndex = 3;
            this.cmdMEM.Text = "Placeholder Max Memory";
            this.cmdMEM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdMEMslots
            // 
            this.cmdMEMslots.AutoSize = true;
            this.cmdMEMslots.BackColor = System.Drawing.Color.Transparent;
            this.cmdMEMslots.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMEMslots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdMEMslots.Location = new System.Drawing.Point(550, 328);
            this.cmdMEMslots.Name = "cmdMEMslots";
            this.cmdMEMslots.Size = new System.Drawing.Size(424, 35);
            this.cmdMEMslots.TabIndex = 4;
            this.cmdMEMslots.Text = "Placeholder Memory Slots";
            this.cmdMEMslots.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdMEMavailable
            // 
            this.cmdMEMavailable.AutoSize = true;
            this.cmdMEMavailable.BackColor = System.Drawing.Color.Transparent;
            this.cmdMEMavailable.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMEMavailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdMEMavailable.Location = new System.Drawing.Point(550, 363);
            this.cmdMEMavailable.Name = "cmdMEMavailable";
            this.cmdMEMavailable.Size = new System.Drawing.Size(574, 35);
            this.cmdMEMavailable.TabIndex = 5;
            this.cmdMEMavailable.Text = "Placeholder Memory Slots Available";
            // 
            // runPING
            // 
            this.runPING.BackColor = System.Drawing.Color.Black;
            this.runPING.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runPING.ForeColor = System.Drawing.Color.Fuchsia;
            this.runPING.Location = new System.Drawing.Point(12, 772);
            this.runPING.Name = "runPING";
            this.runPING.Size = new System.Drawing.Size(270, 50);
            this.runPING.TabIndex = 6;
            this.runPING.Text = "PING";
            this.runPING.UseVisualStyleBackColor = false;
            this.runPING.Click += new System.EventHandler(this.runPING_Click);
            // 
            // cpuTEMP
            // 
            this.cpuTEMP.AutoSize = true;
            this.cpuTEMP.BackColor = System.Drawing.Color.Transparent;
            this.cpuTEMP.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.cpuTEMP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cpuTEMP.Location = new System.Drawing.Point(552, 580);
            this.cpuTEMP.Name = "cpuTEMP";
            this.cpuTEMP.Size = new System.Drawing.Size(378, 35);
            this.cpuTEMP.TabIndex = 8;
            this.cpuTEMP.Text = "Placeholder CPU Temp";
            // 
            // tempTimer
            // 
            this.tempTimer.Interval = 2000;
            // 
            // gpuTEMP
            // 
            this.gpuTEMP.AutoSize = true;
            this.gpuTEMP.BackColor = System.Drawing.Color.Transparent;
            this.gpuTEMP.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.gpuTEMP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gpuTEMP.Location = new System.Drawing.Point(552, 615);
            this.gpuTEMP.Name = "gpuTEMP";
            this.gpuTEMP.Size = new System.Drawing.Size(379, 35);
            this.gpuTEMP.TabIndex = 9;
            this.gpuTEMP.Text = "Placeholder GPU Temp";
            // 
            // cmdMOBO
            // 
            this.cmdMOBO.AutoSize = true;
            this.cmdMOBO.BackColor = System.Drawing.Color.Transparent;
            this.cmdMOBO.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.cmdMOBO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdMOBO.Location = new System.Drawing.Point(20, 222);
            this.cmdMOBO.Name = "cmdMOBO";
            this.cmdMOBO.Size = new System.Drawing.Size(406, 35);
            this.cmdMOBO.TabIndex = 10;
            this.cmdMOBO.Text = "Placeholder Motherboard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 64);
            this.label1.TabIndex = 11;
            this.label1.Text = "NVISION";
            // 
            // cmdBATTERY
            // 
            this.cmdBATTERY.AutoSize = true;
            this.cmdBATTERY.BackColor = System.Drawing.Color.Transparent;
            this.cmdBATTERY.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.cmdBATTERY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdBATTERY.Location = new System.Drawing.Point(14, 474);
            this.cmdBATTERY.Name = "cmdBATTERY";
            this.cmdBATTERY.Size = new System.Drawing.Size(439, 35);
            this.cmdBATTERY.TabIndex = 12;
            this.cmdBATTERY.Text = "Placeholder Battery Health";
            // 
            // cmdSMART
            // 
            this.cmdSMART.AutoSize = true;
            this.cmdSMART.BackColor = System.Drawing.Color.Transparent;
            this.cmdSMART.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.cmdSMART.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdSMART.Location = new System.Drawing.Point(15, 569);
            this.cmdSMART.Name = "cmdSMART";
            this.cmdSMART.Size = new System.Drawing.Size(404, 35);
            this.cmdSMART.TabIndex = 13;
            this.cmdSMART.Text = "Placeholder Drive Health";
            // 
            // cmdBIOSVER
            // 
            this.cmdBIOSVER.AutoSize = true;
            this.cmdBIOSVER.BackColor = System.Drawing.Color.Transparent;
            this.cmdBIOSVER.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.cmdBIOSVER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdBIOSVER.Location = new System.Drawing.Point(20, 363);
            this.cmdBIOSVER.Name = "cmdBIOSVER";
            this.cmdBIOSVER.Size = new System.Drawing.Size(421, 35);
            this.cmdBIOSVER.TabIndex = 13;
            this.cmdBIOSVER.Text = "Placeholder BIOS Version";
            // 
            // cmdMEMSPEED
            // 
            this.cmdMEMSPEED.AutoSize = true;
            this.cmdMEMSPEED.BackColor = System.Drawing.Color.Transparent;
            this.cmdMEMSPEED.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMEMSPEED.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdMEMSPEED.Location = new System.Drawing.Point(550, 293);
            this.cmdMEMSPEED.Name = "cmdMEMSPEED";
            this.cmdMEMSPEED.Size = new System.Drawing.Size(441, 35);
            this.cmdMEMSPEED.TabIndex = 4;
            this.cmdMEMSPEED.Text = "Placeholder Memory Speed";
            this.cmdMEMSPEED.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdMEMCAPACITY
            // 
            this.cmdMEMCAPACITY.AutoSize = true;
            this.cmdMEMCAPACITY.BackColor = System.Drawing.Color.Transparent;
            this.cmdMEMCAPACITY.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMEMCAPACITY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdMEMCAPACITY.Location = new System.Drawing.Point(550, 258);
            this.cmdMEMCAPACITY.Name = "cmdMEMCAPACITY";
            this.cmdMEMCAPACITY.Size = new System.Drawing.Size(481, 35);
            this.cmdMEMCAPACITY.TabIndex = 4;
            this.cmdMEMCAPACITY.Text = "Placeholder Memory Capacity";
            this.cmdMEMCAPACITY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sourceCODE
            // 
            this.sourceCODE.BackColor = System.Drawing.Color.Black;
            this.sourceCODE.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold);
            this.sourceCODE.ForeColor = System.Drawing.Color.Fuchsia;
            this.sourceCODE.Location = new System.Drawing.Point(291, 12);
            this.sourceCODE.Name = "sourceCODE";
            this.sourceCODE.Size = new System.Drawing.Size(92, 39);
            this.sourceCODE.TabIndex = 14;
            this.sourceCODE.Text = "SOURCE";
            this.sourceCODE.UseVisualStyleBackColor = false;
            this.sourceCODE.Click += new System.EventHandler(this.sourceCODE_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(552, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "Memory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 35);
            this.label3.TabIndex = 16;
            this.label3.Text = "Battery";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 35);
            this.label4.TabIndex = 16;
            this.label4.Text = "Drive";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 35);
            this.label5.TabIndex = 16;
            this.label5.Text = "BIOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 35);
            this.label6.TabIndex = 16;
            this.label6.Text = "Motherboard";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(552, 545);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 35);
            this.label7.TabIndex = 16;
            this.label7.Text = "Temperature";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 35);
            this.label8.TabIndex = 16;
            this.label8.Text = "Serial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1132, 843);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sourceCODE);
            this.Controls.Add(this.cmdBIOSVER);
            this.Controls.Add(this.cmdSMART);
            this.Controls.Add(this.cmdBATTERY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdMOBO);
            this.Controls.Add(this.gpuTEMP);
            this.Controls.Add(this.cpuTEMP);
            this.Controls.Add(this.runPING);
            this.Controls.Add(this.cmdMEMavailable);
            this.Controls.Add(this.cmdMEMCAPACITY);
            this.Controls.Add(this.cmdMEMSPEED);
            this.Controls.Add(this.cmdMEMslots);
            this.Controls.Add(this.cmdMEM);
            this.Controls.Add(this.runDISM);
            this.Controls.Add(this.cmdSERIAL);
            this.Controls.Add(this.runSFC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Nvision";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cmdSERIAL;
        private System.Windows.Forms.Button runSFC;
        private System.Windows.Forms.Button runDISM;
        private System.Windows.Forms.Label cmdMEM;
        private System.Windows.Forms.Label cmdMEMslots;
        private System.Windows.Forms.Label cmdMEMavailable;
        private System.Windows.Forms.Button runPING;
        private System.Windows.Forms.Label cpuTEMP;
        private System.Windows.Forms.Timer tempTimer;
        private System.Windows.Forms.Label gpuTEMP;
        private System.Windows.Forms.Label cmdMOBO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cmdBATTERY;
        private System.Windows.Forms.Label cmdSMART;
        private System.Windows.Forms.Label cmdBIOSVER;
        private System.Windows.Forms.Label cmdMEMSPEED;
        private System.Windows.Forms.Label cmdMEMCAPACITY;
        private System.Windows.Forms.Button sourceCODE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

