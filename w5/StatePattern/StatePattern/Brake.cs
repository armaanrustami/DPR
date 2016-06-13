namespace StatePattern
{
    internal class Brake : State
    {
        public override void doAction(Controller control)
        {
            control.Speed--;
        }

        public override string ToString()
        {
            return "Brake pressed";
        }
    }
}