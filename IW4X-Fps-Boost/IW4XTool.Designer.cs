namespace IW4X_Fps_Boost
{
    partial class IW4XTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IW4XTool));
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.ProcOpenLabel = new System.Windows.Forms.Label();
            this.FPSBoost = new System.Windows.Forms.CheckBox();
            this.Bob = new System.Windows.Forms.CheckBox();
            this.Lunge = new System.Windows.Forms.CheckBox();
            this.Filmtweaks = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IW4X:";
            // 
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.BackColor = System.Drawing.Color.White;
            this.ProcOpenLabel.ForeColor = System.Drawing.Color.Red;
            this.ProcOpenLabel.Location = new System.Drawing.Point(47, 9);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Size = new System.Drawing.Size(27, 13);
            this.ProcOpenLabel.TabIndex = 1;
            this.ProcOpenLabel.Text = "N/A";
            // 
            // FPSBoost
            // 
            this.FPSBoost.AutoSize = true;
            this.FPSBoost.BackColor = System.Drawing.Color.White;
            this.FPSBoost.ForeColor = System.Drawing.Color.Black;
            this.FPSBoost.Location = new System.Drawing.Point(15, 30);
            this.FPSBoost.Name = "FPSBoost";
            this.FPSBoost.Size = new System.Drawing.Size(76, 17);
            this.FPSBoost.TabIndex = 2;
            this.FPSBoost.Text = "FPS Boost";
            this.FPSBoost.UseVisualStyleBackColor = false;
            this.FPSBoost.CheckedChanged += new System.EventHandler(this.FPSBoost_CheckedChanged);
            // 
            // Bob
            // 
            this.Bob.AutoSize = true;
            this.Bob.BackColor = System.Drawing.Color.White;
            this.Bob.ForeColor = System.Drawing.Color.Black;
            this.Bob.Location = new System.Drawing.Point(15, 52);
            this.Bob.Name = "Bob";
            this.Bob.Size = new System.Drawing.Size(103, 17);
            this.Bob.TabIndex = 3;
            this.Bob.Text = "Disable Bobbing";
            this.Bob.UseVisualStyleBackColor = false;
            this.Bob.CheckedChanged += new System.EventHandler(this.Bob_CheckedChanged);
            // 
            // Lunge
            // 
            this.Lunge.AutoSize = true;
            this.Lunge.BackColor = System.Drawing.Color.White;
            this.Lunge.ForeColor = System.Drawing.Color.Black;
            this.Lunge.Location = new System.Drawing.Point(15, 73);
            this.Lunge.Name = "Lunge";
            this.Lunge.Size = new System.Drawing.Size(270, 17);
            this.Lunge.TabIndex = 4;
            this.Lunge.Text = "Infinite Knife Lunge (Require Commando PRO Perk)";
            this.Lunge.UseVisualStyleBackColor = false;
            this.Lunge.CheckedChanged += new System.EventHandler(this.Lunge_CheckedChanged);
            // 
            // Filmtweaks
            // 
            this.Filmtweaks.AutoSize = true;
            this.Filmtweaks.BackColor = System.Drawing.Color.White;
            this.Filmtweaks.ForeColor = System.Drawing.Color.Black;
            this.Filmtweaks.Location = new System.Drawing.Point(15, 93);
            this.Filmtweaks.Name = "Filmtweaks";
            this.Filmtweaks.Size = new System.Drawing.Size(118, 17);
            this.Filmtweaks.TabIndex = 5;
            this.Filmtweaks.Text = "Enable FilmTweaks";
            this.Filmtweaks.UseVisualStyleBackColor = false;
            this.Filmtweaks.CheckedChanged += new System.EventHandler(this.Filmtweaks_CheckedChanged);
            // 
            // IW4XTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(300, 116);
            this.Controls.Add(this.Filmtweaks);
            this.Controls.Add(this.Lunge);
            this.Controls.Add(this.Bob);
            this.Controls.Add(this.FPSBoost);
            this.Controls.Add(this.ProcOpenLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IW4XTool";
            this.ShowIcon = false;
            this.Text = "IW4X Tool v0.7.5-dev x86";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProcOpenLabel;
        private System.Windows.Forms.CheckBox FPSBoost;
        private System.Windows.Forms.CheckBox Bob;
        private System.Windows.Forms.CheckBox Lunge;
        private System.Windows.Forms.CheckBox Filmtweaks;
    }
}

