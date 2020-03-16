using System;
using System.Collections.Generic;
using System.Text;

namespace TestEvents.Tank
{
    public class TankPlayer : TankBase
    {
        public KeyPress keyPress;
        private char key;
        public char Key
        {
            get { return key; }
            //set { key = value; }
        }

        public TankPlayer()
        {
            keyPress = new KeyPress();
            keyPress.KeyPressed += KeyPressHandler;
        }

        private void KeyPressHandler(object sender, KeyPressedArgs e)
        {
            //Console.WriteLine(e.Key);
            key = e.Key;

            switch ((ConsoleKey)Key)
            {
                case ConsoleKey.W:
                    PositionX++;
                    Move();
                    break;
                case ConsoleKey.S:
                    PositionX--;
                    Move();
                    break;
                case ConsoleKey.D:
                    PositionY++;
                    Move();
                    break;
                case ConsoleKey.A:
                    PositionY--;
                    Move();
                    break;
            }
        }

        public override void Update()
        {
            keyPress.Update();           
        }
    }
}
