namespace StatePattern
{
    public class OFF : State
    {
        public override void doAction(Controller control)
        {
            control.currentstate = false;
        }

        public override string ToString()
        {
            return "Car stopped";
        }
    }
}