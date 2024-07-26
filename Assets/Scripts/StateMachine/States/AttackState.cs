namespace Game
{
    public class AttackState : State
    {
        private Entity entity;
        private const string animationName = "Attack";

        public AttackState(Entity entity)
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
