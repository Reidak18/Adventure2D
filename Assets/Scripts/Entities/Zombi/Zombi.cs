using UnityEngine;

namespace Game
{
    public class Zombi : Entity
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                stateMachine.SetState(new AppearState(this));
            else if (Input.GetKeyDown(KeyCode.W))
                stateMachine.SetState(new WalkState(this));
            else if (Input.GetKeyDown(KeyCode.A))
                stateMachine.SetState(new AttackState(this));
            else if (Input.GetKeyDown(KeyCode.D))
                stateMachine.SetState(new DieState(this));
        }
    }
}