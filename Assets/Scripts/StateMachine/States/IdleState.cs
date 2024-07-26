namespace Game
{
    public class IdleState : State
    {
        private Entity entity;
        private const string animationName = "Idle";

        public IdleState(Entity entity)
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
