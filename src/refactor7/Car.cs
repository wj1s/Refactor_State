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
            State = State.TransformWhenCarACC();
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