namespace state
{
    public class StopState : State
    {
        public override State TransformWhenCarACC()
        {
            return this;
        }
    }
}