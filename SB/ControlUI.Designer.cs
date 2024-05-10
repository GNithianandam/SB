namespace SB
{
    partial class ControlUI
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
            components = new System.ComponentModel.Container();
            T1Name = new TextBox();
            T2Name = new TextBox();
            T1Scored = new Button();
            T2Scored = new Button();
            TimerValue = new TextBox();
            TimeLabel = new Label();
            UITimer = new System.Windows.Forms.Timer(components);
            StartButton = new Button();
            PauseButton = new Button();
            ResumeButton = new Button();
            T1Jersey = new TextBox();
            T2Jersey = new TextBox();
            SuspendLayout();
            // 
            // T1Name
            // 
            T1Name.Location = new Point(12, 75);
            T1Name.Name = "T1Name";
            T1Name.Size = new Size(125, 27);
            T1Name.TabIndex = 0;
            T1Name.TextChanged += T1Name_TextChanged;
            // 
            // T2Name
            // 
            T2Name.Location = new Point(256, 75);
            T2Name.Name = "T2Name";
            T2Name.Size = new Size(125, 27);
            T2Name.TabIndex = 1;
            T2Name.TextChanged += T2Name_TextChanged;
            // 
            // T1Scored
            // 
            T1Scored.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            T1Scored.Location = new Point(35, 126);
            T1Scored.Name = "T1Scored";
            T1Scored.Size = new Size(64, 73);
            T1Scored.TabIndex = 2;
            T1Scored.Text = "+";
            T1Scored.TextAlign = ContentAlignment.TopCenter;
            T1Scored.UseVisualStyleBackColor = true;
            T1Scored.Click += T1Scored_Click;
            // 
            // T2Scored
            // 
            T2Scored.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            T2Scored.Location = new Point(287, 126);
            T2Scored.Name = "T2Scored";
            T2Scored.Size = new Size(64, 73);
            T2Scored.TabIndex = 3;
            T2Scored.Text = "+";
            T2Scored.TextAlign = ContentAlignment.TopCenter;
            T2Scored.UseVisualStyleBackColor = true;
            T2Scored.Click += T2Scored_Click;
            // 
            // TimerValue
            // 
            TimerValue.Location = new Point(69, 26);
            TimerValue.Name = "TimerValue";
            TimerValue.Size = new Size(68, 27);
            TimerValue.TabIndex = 4;
            TimerValue.TextChanged += TimerValue_TextChanged;
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(12, 26);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(42, 20);
            TimeLabel.TabIndex = 5;
            TimeLabel.Text = "Time";
            // 
            // UITimer
            // 
            UITimer.Enabled = true;
            UITimer.Interval = 500;
            UITimer.Tick += UITimer_Tick;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(152, 182);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(94, 29);
            StartButton.TabIndex = 6;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // PauseButton
            // 
            PauseButton.Location = new Point(152, 182);
            PauseButton.Name = "PauseButton";
            PauseButton.Size = new Size(94, 29);
            PauseButton.TabIndex = 7;
            PauseButton.Text = "Pause";
            PauseButton.UseVisualStyleBackColor = true;
            PauseButton.Click += PauseButton_Click;
            // 
            // ResumeButton
            // 
            ResumeButton.Location = new Point(152, 182);
            ResumeButton.Name = "ResumeButton";
            ResumeButton.Size = new Size(94, 29);
            ResumeButton.TabIndex = 8;
            ResumeButton.Text = "Resume";
            ResumeButton.UseVisualStyleBackColor = true;
            ResumeButton.Click += ResumeButton_Click;
            // 
            // T1Jersey
            // 
            T1Jersey.Location = new Point(35, 208);
            T1Jersey.Name = "T1Jersey";
            T1Jersey.Size = new Size(64, 27);
            T1Jersey.TabIndex = 9;
            // 
            // T2Jersey
            // 
            T2Jersey.Location = new Point(287, 208);
            T2Jersey.Name = "T2Jersey";
            T2Jersey.Size = new Size(64, 27);
            T2Jersey.TabIndex = 10;
            // 
            // ControlUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 247);
            Controls.Add(T2Jersey);
            Controls.Add(T1Jersey);
            Controls.Add(TimeLabel);
            Controls.Add(TimerValue);
            Controls.Add(T2Scored);
            Controls.Add(T1Scored);
            Controls.Add(T2Name);
            Controls.Add(T1Name);
            Controls.Add(ResumeButton);
            Controls.Add(PauseButton);
            Controls.Add(StartButton);
            Name = "ControlUI";
            Text = "ControlUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox T1Name;
        private TextBox T2Name;
        private Button T1Scored;
        private Button T2Scored;
        private TextBox TimerValue;
        private Label TimeLabel;
        private System.Windows.Forms.Timer UITimer;
        private Button StartButton;
        private Button PauseButton;
        private Button ResumeButton;
        private TextBox T1Jersey;
        private TextBox T2Jersey;
    }
}