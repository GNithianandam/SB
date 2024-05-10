using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SB
{
    public partial class ControlUI : Form
    {
        public ControlUI()
        {
            InitializeComponent();
        }

        private void T1Name_TextChanged(object sender, EventArgs e)
        {
            SBModel.T1Name = T1Name.Text;
        }

        private void T2Name_TextChanged(object sender, EventArgs e)
        {
            SBModel.T2Name = T2Name.Text;
        }

        private void T1Scored_Click(object sender, EventArgs e)
        {
            SBModel.T1Scored(T1Jersey.Text);
            T1Jersey.Text = "";
        }

        private void T2Scored_Click(object sender, EventArgs e)
        {
            SBModel.T2Scored(T2Jersey.Text);
            T2Jersey.Text = "";
        }

        private void UITimer_Tick(object sender, EventArgs e)
        {
            if (SBModel.Started)
            {
                StartButton.Visible = false;
                if (SBModel.Paused)
                {
                    ResumeButton.Visible = true;
                    PauseButton.Visible = false;
                }
                else
                {
                    ResumeButton.Visible = false;
                    PauseButton.Visible = true;
                }
            }
            else
            {
                StartButton.Visible = true;
                ResumeButton.Visible = false;
                PauseButton.Visible = false;
            }


        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            SBModel.Pause();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            T1Name.ReadOnly = true;
            T2Name.ReadOnly = true;
            TimerValue.ReadOnly = true;
            SBModel.StartTimer();
       
        }

        private void TimerValue_TextChanged(object sender, EventArgs e)
        {
            SBModel.SetHalfTime(Convert.ToInt16(TimerValue.Text));
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            SBModel.Resume();
        }
    }
}
