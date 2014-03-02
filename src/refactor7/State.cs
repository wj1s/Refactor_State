namespace state
{
    public abstract class State
    {
        public static State Stop = new StopState();
        public static State Geared = new GearedState();
        public static State Ready = new ReadyState();
        public static State MoveForward = new MoveForwardState();

        public abstract State TransformWhenCarACC();
    }
}