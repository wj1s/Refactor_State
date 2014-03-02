namespace state
{
    public class Car
    {
        public State State { get; private set; }

        public Car(State state)
        {
            State = state;
        }

        public void ACC()
        {
        }

        public void Gear()
        {
            State = State.Geared;
        }
    }
}