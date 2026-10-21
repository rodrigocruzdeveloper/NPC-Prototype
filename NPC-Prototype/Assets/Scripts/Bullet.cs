using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float timeToDetroy;

    void Start()
    {
        Destroy(gameObject, timeToDetroy);
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }




}
