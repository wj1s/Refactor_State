namespace state
{
    public class MoveForwardState : State
    {
        public override State TransformWhenCarACC()
        {
            return this;
        }
    }
}