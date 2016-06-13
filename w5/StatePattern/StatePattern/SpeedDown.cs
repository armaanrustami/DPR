namespace StatePattern
{
    internal class SpeedDown : State
    {
        private int speed;

        public override void doAction(Controller control)
        {
            speed = --control.Speed;
        }

        public override string ToString()
        {
            return "Speed downed to " + speed;
        }
    }
}