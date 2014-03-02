namespace state
{
    public class ReadyState : State
    {
        public override State TransformWhenCarACC()
        {
            return MoveForward;
        }
    }
}