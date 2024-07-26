using UnityEngine;

namespace Game
{
    public abstract class Entity : MonoBehaviour
    {
        protected StateMachine stateMachine;
        private Animator animator;

        private void Awake()
        {
            stateMachine = new StateMachine();
            animator = GetComponentInChildren<Animator>();
        }

        public void SetAnimationTrigger(string trigger)
        {
            animator.SetTrigger(trigger);
        }
    }
}
