namespace Game
{
    public class StateMachine
    {
        public State currentState { get; private set; }

        public StateMachine(State startState = null)
        {
            currentState = startState == null ? new EmptyState() : startState;
            currentState.Enter();
        }

        public void SetState(State newState)
        {
            currentState.Exit();
            currentState = newState;
            currentState.Enter();
        }
    }
}