using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gonki
{
    class Settings
    {
        public static int TimerSpeed;
        public static float GameSpeed;
        public static int CarTurnSpeed;
        public static bool IsGameOver;
        public static float MinSpeed;
        public static float MaxSpeed;

        public Settings()
        {
            MinSpeed = 1;
            MaxSpeed = 21;
            TimerSpeed = 100;
            GameSpeed = 4;
            CarTurnSpeed = 10;

            IsGameOver = false;
        }
    }
}
