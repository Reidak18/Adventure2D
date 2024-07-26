namespace Game
{
    public class AppearState : State
    {
        private Entity entity;
        private const string animationName = "Appear";

        public AppearState(Entity entity)
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
