namespace state
{
    public class GearedState : State
    {
        public override State TransformWhenCarACC()
        {
            return this;
        }
    }
}