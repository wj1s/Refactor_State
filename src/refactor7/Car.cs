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
            if (State == State.Ready)
            {
                State = State.MoveForward;
            }
        }

        public void Gear()
        {
            State = State.Geared;
        }

        public void ReleaseBreak()
        {
            State = State.Ready;
        }

        public void ReverseGear()
        {
        }
    }
}