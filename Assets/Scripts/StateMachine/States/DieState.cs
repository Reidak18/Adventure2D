namespace Game
{
    public class DieState : State
    {
        private Entity entity;
        private const string animationName = "Die";

        public DieState(Entity entity)
        {
            this.entity = entity;
        }

        public override void Enter()
        {
            base.Enter();
            entity.SetAnimationTrigger(animationName);
        }
    }
}
