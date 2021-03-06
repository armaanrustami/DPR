﻿namespace StatePattern
{
    internal class SpeedUp : State
    {
        private int speed;

        public override void doAction(Controller control)
        {
            speed = ++control.Speed;
        }

        public override string ToString()
        {
            return "Speed upped to " + speed;
        }
    }
}