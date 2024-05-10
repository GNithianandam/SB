using System.Timers;
using System;
namespace SB
{
    public static class SBModel
    {
        public static string T1Name = "";
        public static string T2Name = "";
        public static int T1Score = 0;
        public static int T2Score = 0;
        public static int Leg = 0;
        private static double HalfTime = 0;
        public static double HalfTime_Sec = 0;        
        public static bool Paused = false;
        public static bool Started = false;
        public static bool blink = false;
        private static System.Timers.Timer Tick;
        public static string T1F = "";
        public static string T2F = "";
        public static string T1S = "";
        public static string T2S = "";

        public static void T1Scored(string J)
        {
            T1Score++;
            var timeSpan = TimeSpan.FromSeconds(SBModel.HalfTime_Sec);
            string result = J + " " + timeSpan.ToString(@"mm\:ss");
            if (Leg == 0) T1F += result+",";
            if (Leg == 1) T1S += result + ",";
        }

        public static void T2Scored(string J)
        {
            T2Score++;
            var timeSpan = TimeSpan.FromSeconds(SBModel.HalfTime_Sec);
            string result = J + " " + timeSpan.ToString(@"mm\:ss");
            if (Leg == 0) T2F += result + ",";
            if (Leg == 1) T2S += result + ",";
        }
        public static void SetHalfTime(int time) 
        {
            HalfTime = time;
        }
        public static void Pause() { Paused = true; }

        public static void Resume() { Paused = false; }

        public static void StartTimer()
        {
            if (Started) return;
            blink = false;
            Started = true;
            Tick = new System.Timers.Timer(1000);
            HalfTime_Sec = HalfTime * 60;          
            Tick.Elapsed += TickEvent;
            Tick.AutoReset = true;
            Tick.Enabled = true;
    
        }
        private static void TickEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (!Paused && Started)
            {
                if (HalfTime_Sec > 0) HalfTime_Sec--;
                else
                {
                    HalfTime_Sec = 0;
                    Tick.Enabled = false;
                    Started = false;
                    blink = true;
                    Leg++;
                    if (Leg == 2)
                    {
                        Log.CreateLog(); //creates log file
                    }
                    Tick.Dispose();
                }
                

            }
        }
    }
}
