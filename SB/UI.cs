namespace SB
{
    public partial class UI : Form
    {
        private int BlinkTime=0;
        
        public UI()
        {
            InitializeComponent();

        }
       
        private void UITimer_Tick(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                
                if (SBModel.Leg == 0)
                {
                    Team1Name.Text = SBModel.T1Name;
                    Team2Name.Text = SBModel.T2Name;
                    Team1Score.Text = SBModel.T1Score.ToString();
                    Team2Score.Text = SBModel.T2Score.ToString();
                    GameLeg.Text = "First Half";
                }
                if (SBModel.Leg == 1)
                {

                        
                    Team1Name.Text = SBModel.T2Name;
                    Team2Name.Text = SBModel.T1Name;
                    Team1Score.Text = SBModel.T2Score.ToString();
                    Team2Score.Text = SBModel.T1Score.ToString();
                    GameLeg.Text = "Second Half";
                }
                if (SBModel.Leg == 2) GameLeg.Text = "Game Finished";

                if (SBModel.blink)
                {
                    if (BlinkTime < 10)
                    {
                        if (Blink.BackColor == Color.White) Blink.BackColor = Color.Red;
                        else Blink.BackColor = Color.White;
                        BlinkTime++;
                    }
                }
                else
                {
                    BlinkTime = 0;
                    Blink.BackColor = Color.White;
                }

                var timeSpan = TimeSpan.FromSeconds(SBModel.HalfTime_Sec);
                CountDown.Text = timeSpan.ToString(@"mm\:ss");
            });

        }



    }
}
