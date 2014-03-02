namespace state
{
    public class Car
    {
        public State State { get; private set; }

        public Car(State state)
        {
            this.State = state;
        }

        public void ACC()
        {
        }
    }
}