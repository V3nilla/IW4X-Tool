using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Memory;

namespace IW4X_Fps_Boost
{
    public partial class IW4XTool : Form
    {
        public Mem m = new Mem();
        public IW4XTool()
        {
            InitializeComponent();
        }

        bool ProcOpen = false;

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcOpen = m.OpenProcess("iw4x");
            Thread.Sleep(1000);
            BGWorker.ReportProgress(0);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                ProcOpenLabel.ForeColor = Color.Green;
                ProcOpenLabel.Text = "Found";
            }
            else
            {
                ProcOpenLabel.ForeColor = Color.Red;
                ProcOpenLabel.Text = "N/A";
            }
        }


        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void FPSBoost_CheckedChanged(object sender, EventArgs e)
        {
            if (FPSBoost.Checked)
            {
                m.FreezeValue("base+60064C0", "int", "0");
                m.FreezeValue("base+6008CC0", "int", "0");
                m.FreezeValue("base+6009080", "int", "0");
            }
            else
            {
                m.UnfreezeValue("base+60064C0");
                m.UnfreezeValue("base+6008CC0");
                m.UnfreezeValue("base+6009080");
                m.WriteMemory("base+60064C0", "int", "1");
                m.WriteMemory("base+6008CC0", "int", "1");
                m.WriteMemory("base+6009080", "int", "1");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ProcOpen)
            {
                m.UnfreezeValue("base+60064C0");
                m.UnfreezeValue("base+6008CC0");
                m.UnfreezeValue("base+60119B0");
                m.UnfreezeValue("base+6011C30");
                m.UnfreezeValue("base+60126D0");
                m.UnfreezeValue("base+6014520");
                m.UnfreezeValue("base+6014530");
                m.UnfreezeValue("base+6009080");
                m.WriteMemory("base+60064C0", "int", "1");
                m.WriteMemory("base+6008CC0", "int", "1");
                m.WriteMemory("base+60119B0", "float", "8");
                m.WriteMemory("base+6011C30", "float", "8");
                m.WriteMemory("base+60126D0", "float", "0.5");
                m.WriteMemory("base+6014520", "float", "176");
                m.WriteMemory("base+6014530", "float", "176");
                m.WriteMemory("base+6009080", "int", "1");
                Application.Exit();
                Environment.Exit(0);
            }
            else
            {
                Application.Exit();
                Environment.Exit(0);
            }
        }

        private void Bob_CheckedChanged(object sender, EventArgs e)
        {
            if (Bob.Checked)
            {
                m.FreezeValue("base+60119B0", "float", "0");
                m.FreezeValue("base+6011C30", "float", "0");
                m.FreezeValue("base+60126D0", "float", "0");
            }
            else
            {
                m.UnfreezeValue("base+60119B0");
                m.UnfreezeValue("base+6011C30");
                m.UnfreezeValue("base+60126D0");
                m.WriteMemory("base+60119B0", "float", "8");
                m.WriteMemory("base+6011C30", "float", "8");
                m.WriteMemory("base+60126D0", "float", "0.5");
            }
        }

        private void Lunge_CheckedChanged(object sender, EventArgs e)
        {
            if (Lunge.Checked)
            {
                m.FreezeValue("base+6014520", "float", "9999");
                m.FreezeValue("base+6014530", "float", "9999");
            }
            else
            {
                m.UnfreezeValue("base+6014520");
                m.UnfreezeValue("base+6014530");
                m.WriteMemory("base+6014520", "float", "176");
                m.WriteMemory("base+6014530", "float", "176");
            }
        }
    }
}
