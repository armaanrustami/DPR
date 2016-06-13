namespace StatePattern
{
    public class Controller
    {
        public bool currentstate;
        private State state;

        public Controller()
        {
            state = null;
        }

        public int Speed { get; set; }

        public State getState()
        {
            return state;
        }

        public void setState(State state)
        {
            this.state = state;
        }
    }
}