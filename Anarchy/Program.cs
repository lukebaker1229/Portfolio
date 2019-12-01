using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace PC_Prank
{
    class Program
    {
        public static Random _random = new Random();

        public static int _startupDelaySeconds = 10;
        public static int _totalDurationSeconds = 10;


        static void Main(string[] args)
        {
            Console.WriteLine("Haywire Prank Application by: Luke (aka. Cypher)");

            if (args.Length >= 2)
            {
                _startupDelaySeconds = Convert.ToInt32(args[0]);
                _totalDurationSeconds = Convert.ToInt32(args[1]);
            }

            // Manipulates all inputes and outputs to the system
            Thread drunkMouseThread = new Thread(new ThreadStart(DrunkMouseThread));
            Thread drunkKeyboardThread = new Thread(new ThreadStart(DrunkKeyboardThread));
            Thread drunkSoundThread = new Thread(new ThreadStart(DrunkSoundThread));
            Thread drunkPopupThread = new Thread(new ThreadStart(DrunkPopupThread));

            DateTime future = DateTime.Now.AddSeconds(_startupDelaySeconds);
            Console.WriteLine("Waiting 10 seconds before starting program");
            while (future > DateTime.Now)
            {
                Thread.Sleep(1000);
            }

            // Start the program threads
            drunkMouseThread.Start();
            drunkKeyboardThread.Start();
            drunkSoundThread.Start();
            drunkPopupThread.Start();

            future = DateTime.Now.AddSeconds(_totalDurationSeconds);
            while (future > DateTime.Now)
            {
                Thread.Sleep(1000);
            }

            Console.WriteLine("Terminating program");

            // Kill all Threads
            drunkMouseThread.Abort();
            drunkKeyboardThread.Abort();
            drunkSoundThread.Abort();
            drunkPopupThread.Abort();

        }

        #region Thread Functions
        /// <summary>
        /// This thread effects mouse movement
        /// </summary>
        public static void DrunkMouseThread()
        {
            Console.WriteLine("DrunkMouseThreadStarted");

            int moveX = 0;
            int moveY = 0;

            while(true)
            {
                //Console.WriteLine(Cursor.Position.ToString());

                moveX = _random.Next(20) - 10;
                moveY = _random.Next(20) - 10;

                Cursor.Position = new System.Drawing.Point(
                    Cursor.Position.X + moveX,
                    Cursor.Position.Y + moveY);

                Thread.Sleep(50);
            }
        }

        public static void DrunkKeyboardThread()
        {
            Console.WriteLine("DrunkKeyboardThreadStarted");

            while (true)
            {
                char key = (char)(_random.Next(25)+65);

                if(_random.Next(2)==0)
                {
                    key = char.ToLower(key);
                }

                SendKeys.SendWait(key.ToString());

                Thread.Sleep(_random.Next(50));
            }
        }

        public static void DrunkSoundThread()
        {
            Console.WriteLine("DrunkSoundThreadStarted");

            while (true)
            {
                if(_random.Next(100)>80)
                {
                    switch (_random.Next(5))
                    {
                        case 0:
                            SystemSounds.Asterisk.Play();
                            break;
                        case 1:
                            SystemSounds.Beep.Play();
                            break;
                        case 2:
                            SystemSounds.Exclamation.Play();
                            break;
                        case 3:
                            SystemSounds.Hand.Play();
                            break;
                        case 4:
                            SystemSounds.Question.Play();
                            break;
                    }

                    SystemSounds.Asterisk.Play();
                }

                Thread.Sleep(100);
            }
        }

        public static void DrunkPopupThread()
        {
            Console.WriteLine("DrunkPopupThreadStarted");

            while (true)
            {
                if (_random.Next(100) > 90)
                {
                    switch (_random.Next(2))
                    {
                        case 0:
                            MessageBox.Show(
                               "System.Exe has stopped working",
                               "System.Exe",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 1:
                            MessageBox.Show(
                               "Your system has took a complete nose-dive",
                               "Microsoft computer is fucked",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;     
                    }
                }

                Thread.Sleep(100);
            }
        }

        #endregion
    }
}
