using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private int hours;
        private int minutes;
        private int seconds;

        public Form1()
        {
            InitializeComponent();

            hours = 0;
            minutes = 0;
            seconds = 0;
            UpdateTimerLabel();
        }

        private void UpdateTimerLabel()
        {
            timerLabel.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int totalSeconds = hours * 3600 + minutes * 60 + seconds;
            if (totalSeconds == 0)
            {
                MessageBox.Show("Please set the timer first.");
                return;
            }

            timer1.Interval = 1000;
            timer1.Tag = totalSeconds;
            timer1.Start();
            progressBar1.Maximum = totalSeconds;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int totalSeconds = (int)timer1.Tag;
            totalSeconds--;
            if (totalSeconds >= 0)
            {
                hours = totalSeconds / 3600;
                minutes = (totalSeconds % 3600) / 60;
                seconds = totalSeconds % 60;
                UpdateTimerLabel();
                progressBar1.Value = progressBar1.Maximum - totalSeconds;
            }
            else
            {
                timer1.Stop();
                progressBar1.Value = progressBar1.Maximum;
                MessageBox.Show("Timer has finished!");

                for (int i = 0; i < 4; i++)
                {
                    this.BackColor = SystemColors.Control;
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(100);
                    this.BackColor = SystemColors.Highlight;
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(100);
                }
            }
        }

        private void hoursTrackBar_Scroll(object sender, EventArgs e)
        {
            hours = hoursTrackBar.Value;
            UpdateTimerLabel();
        }

        private void minutesTrackBar_Scroll(object sender, EventArgs e)
        {
            minutes = minutesTrackBar.Value;
            UpdateTimerLabel();
        }

        private void secondsTrackBar_Scroll(object sender, EventArgs e)
        {
            seconds = secondsTrackBar.Value;
            UpdateTimerLabel();
        }
    }
}

