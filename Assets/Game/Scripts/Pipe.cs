using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Score.GainScore();
    }
}
