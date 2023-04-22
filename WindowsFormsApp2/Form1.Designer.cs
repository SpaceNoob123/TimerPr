using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class Form1
    {

        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TrackBar hoursTrackBar;
        private TrackBar minutesTrackBar;
        private TrackBar secondsTrackBar;
        private Button startButton;
        private Label timerLabel;
        private Timer timer1;
        private ProgressBar progressBar1;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hoursTrackBar = new System.Windows.Forms.TrackBar();
            this.minutesTrackBar = new System.Windows.Forms.TrackBar();
            this.secondsTrackBar = new System.Windows.Forms.TrackBar();
            this.startButton = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.hoursTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // hoursTrackBar
            // 
            this.hoursTrackBar.Location = new System.Drawing.Point(9, 10);
            this.hoursTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hoursTrackBar.Maximum = 23;
            this.hoursTrackBar.Name = "hoursTrackBar";
            this.hoursTrackBar.Size = new System.Drawing.Size(166, 45);
            this.hoursTrackBar.TabIndex = 0;
            this.hoursTrackBar.Scroll += new System.EventHandler(this.hoursTrackBar_Scroll);
            // 
            // minutesTrackBar
            // 
            this.minutesTrackBar.Location = new System.Drawing.Point(9, 60);
            this.minutesTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minutesTrackBar.Maximum = 59;
            this.minutesTrackBar.Name = "minutesTrackBar";
            this.minutesTrackBar.Size = new System.Drawing.Size(166, 45);
            this.minutesTrackBar.TabIndex = 1;
            this.minutesTrackBar.Scroll += new System.EventHandler(this.minutesTrackBar_Scroll);
            // 
            // secondsTrackBar
            // 
            this.secondsTrackBar.Location = new System.Drawing.Point(9, 110);
            this.secondsTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.secondsTrackBar.Maximum = 59;
            this.secondsTrackBar.Name = "secondsTrackBar";
            this.secondsTrackBar.Size = new System.Drawing.Size(166, 45);
            this.secondsTrackBar.TabIndex = 2;
            this.secondsTrackBar.Scroll += new System.EventHandler(this.secondsTrackBar_Scroll);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(9, 170);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(166, 30);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(180, 60);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(175, 44);
            this.timerLabel.TabIndex = 4;
            this.timerLabel.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 222);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Maximum = 3600;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(312, 28);
            this.progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 260);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.secondsTrackBar);
            this.Controls.Add(this.minutesTrackBar);
            this.Controls.Add(this.hoursTrackBar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Countdown Timer";
            ((System.ComponentModel.ISupportInitialize)(this.hoursTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

