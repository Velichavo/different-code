using System;
using System.Collections.Generic;
using System.Text;

namespace TestEvents.Tank
{
    public class TankBase : ITankBase
    {
        int positionX;
        int positionY;

        public int PositionX
        {
            get { return positionX; }
            set { positionX = value; }
        }
        public int PositionY
        {
            get { return positionY; }
            set { positionY = value; }
        }
        public void Move()
        {
            Console.WriteLine("Tank moved in: {0}, {1}", PositionX, PositionY);
        }

        public virtual void Update()
        {

        }
    }
}
