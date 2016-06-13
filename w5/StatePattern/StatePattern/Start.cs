namespace StatePattern
{
    public class Start : State
    {
        public override  void doAction(Controller control)
        {
            control.currentstate = true;
        }

        public override string ToString()
        {
            return " Car is Started UP";
        }
    }
}