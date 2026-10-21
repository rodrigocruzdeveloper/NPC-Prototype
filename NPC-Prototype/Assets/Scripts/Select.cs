using System.Collections;
using UnityEngine;

public class Select : MonoBehaviour
{
    public enum State
    {
        Idle,
        Shoot,
        Move
    }

    public State currentState;

    void Update()
    {
        
    }

    IEnumerator Action()
    {
        currentState = State.Idle;
        yield return new WaitForSeconds(0);

        currentState = State.Shoot;
        yield return new WaitForSeconds(0);

        currentState = State.Move;
        yield return new WaitForSeconds(0);
    }
}
