using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Square : MonoBehaviour
{
    public float speed;

    public enum State
    {
        Move,
        Idle,
        Turn
    }

    public State currentState;

    void Start()
    {
        StartCoroutine(ChangeState());
    }

    void Update()
    {
        if (currentState == State.Idle)
        {
            GetComponent<SpriteRenderer>().color = Color.yellow;
        }
        else if (currentState == State.Move)
        {
            GetComponent<SpriteRenderer>().color = Color.green;
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else if (currentState == State.Turn)
        {
            GetComponent<SpriteRenderer>().color = Color.white;

            if(transform.position.x < 0)
            {
                transform.eulerAngles = new Vector2(0, 180);
            }
            else
            {
                transform.eulerAngles = new Vector2(0, 0);
            }
            
        }
    }

    IEnumerator ChangeState()
    {
        currentState = State.Idle;
        yield return new WaitForSeconds(3.0f);

        currentState = State.Move;
        yield return new WaitForSeconds(5.0f);

        currentState = State.Turn;
        yield return new WaitForSeconds(0.1f);

        StartCoroutine(ChangeState());
    }


}
