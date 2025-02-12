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
            this.SuspendLayout();
            // 
            // cmdSERIAL
            // 
            this.cmdSERIAL.AutoSize = true;
            this.cmdSERIAL.BackColor = System.Drawing.Color.Transparent;
            this.cmdSERIAL.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSERIAL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
            this.cmdSERIAL.Location = new System.Drawing.Point(17, 86);
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
            this.runSFC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
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
            this.runDISM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
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
            this.cmdMEM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
            this.cmdMEM.Location = new System.Drawing.Point(17, 121);
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
            this.cmdMEMslots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
            this.cmdMEMslots.Location = new System.Drawing.Point(17, 227);
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
            this.cmdMEMavailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
            this.cmdMEMavailable.Location = new System.Drawing.Point(17, 262);
            this.cmdMEMavailable.Name = "cmdMEMavailable";
            this.cmdMEMavailable.Size = new System.Drawing.Size(574, 35);
            this.cmdMEMavailable.TabIndex = 5;
            this.cmdMEMavailable.Text = "Placeholder Memory Slots Available";
            // 
            // runPING
            // 
            this.runPING.BackColor = System.Drawing.Color.Black;
            this.runPING.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runPING.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
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
            this.cpuTEMP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
            this.cpuTEMP.Location = new System.Drawing.Point(17, 297);
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
            this.gpuTEMP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
            this.gpuTEMP.Location = new System.Drawing.Point(17, 332);
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
            this.cmdMOBO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
            this.cmdMOBO.Location = new System.Drawing.Point(17, 367);
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
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
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
            this.cmdBATTERY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
            this.cmdBATTERY.Location = new System.Drawing.Point(17, 506);
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
            this.cmdSMART.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
            this.cmdSMART.Location = new System.Drawing.Point(17, 541);
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
            this.cmdBIOSVER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
            this.cmdBIOSVER.Location = new System.Drawing.Point(17, 439);
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
            this.cmdMEMSPEED.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
            this.cmdMEMSPEED.Location = new System.Drawing.Point(17, 192);
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
            this.cmdMEMCAPACITY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
            this.cmdMEMCAPACITY.Location = new System.Drawing.Point(17, 157);
            this.cmdMEMCAPACITY.Name = "cmdMEMCAPACITY";
            this.cmdMEMCAPACITY.Size = new System.Drawing.Size(481, 35);
            this.cmdMEMCAPACITY.TabIndex = 4;
            this.cmdMEMCAPACITY.Text = "Placeholder Memory Capacity";
            this.cmdMEMCAPACITY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(781, 843);
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
    }
}

