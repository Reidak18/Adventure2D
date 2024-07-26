namespace Game
{
    public class WalkState : State
    {
        private Entity entity;
        private const string animationName = "Walk";

        public WalkState(Entity entity)
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
