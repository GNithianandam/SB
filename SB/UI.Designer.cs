namespace SB
{
    partial class UI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            CountDown = new TextBox();
            Team2Name = new TextBox();
            Team1Name = new TextBox();
            Team2Score = new TextBox();
            Team1Score = new TextBox();
            GameLeg = new TextBox();
            Blink = new TextBox();
            UITimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // CountDown
            // 
            CountDown.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            CountDown.Location = new Point(219, 170);
            CountDown.Name = "CountDown";
            CountDown.ReadOnly = true;
            CountDown.Size = new Size(361, 114);
            CountDown.TabIndex = 0;
            CountDown.TextAlign = HorizontalAlignment.Center;
            // 
            // Team2Name
            // 
            Team2Name.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            Team2Name.Location = new Point(599, 170);
            Team2Name.Name = "Team2Name";
            Team2Name.ReadOnly = true;
            Team2Name.Size = new Size(175, 70);
            Team2Name.TabIndex = 1;
            Team2Name.TextAlign = HorizontalAlignment.Center;
            // 
            // Team1Name
            // 
            Team1Name.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            Team1Name.Location = new Point(21, 170);
            Team1Name.Name = "Team1Name";
            Team1Name.ReadOnly = true;
            Team1Name.Size = new Size(175, 70);
            Team1Name.TabIndex = 2;
            Team1Name.TextAlign = HorizontalAlignment.Center;
            // 
            // Team2Score
            // 
            Team2Score.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            Team2Score.Location = new Point(636, 271);
            Team2Score.Name = "Team2Score";
            Team2Score.ReadOnly = true;
            Team2Score.Size = new Size(100, 70);
            Team2Score.TabIndex = 3;
            Team2Score.TextAlign = HorizontalAlignment.Center;
            // 
            // Team1Score
            // 
            Team1Score.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            Team1Score.Location = new Point(58, 271);
            Team1Score.Name = "Team1Score";
            Team1Score.ReadOnly = true;
            Team1Score.Size = new Size(100, 70);
            Team1Score.TabIndex = 4;
            Team1Score.TextAlign = HorizontalAlignment.Center;
            // 
            // GameLeg
            // 
            GameLeg.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            GameLeg.Location = new Point(219, 67);
            GameLeg.Name = "GameLeg";
            GameLeg.ReadOnly = true;
            GameLeg.Size = new Size(361, 70);
            GameLeg.TabIndex = 5;
            GameLeg.TextAlign = HorizontalAlignment.Center;
            // 
            // Blink
            // 
            Blink.Enabled = false;
            Blink.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            Blink.Location = new Point(713, 12);
            Blink.Name = "Blink";
            Blink.ReadOnly = true;
            Blink.Size = new Size(75, 70);
            Blink.TabIndex = 6;
            // 
            // UITimer
            // 
            UITimer.Enabled = true;
            UITimer.Interval = 500;
            UITimer.Tick += UITimer_Tick;
            // 
            // UI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Blink);
            Controls.Add(GameLeg);
            Controls.Add(Team1Score);
            Controls.Add(Team2Score);
            Controls.Add(Team1Name);
            Controls.Add(Team2Name);
            Controls.Add(CountDown);
            Name = "UI";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CountDown;
        private TextBox Team2Name;
        private TextBox Team1Name;
        private TextBox Team2Score;
        private TextBox Team1Score;
        private TextBox GameLeg;
        private TextBox Blink;
        private System.Windows.Forms.Timer UITimer;
    }
}
