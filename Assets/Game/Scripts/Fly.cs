using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody2D;
    [SerializeField] float jumpPower = 1f;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    private void Jump()
    {
        rigidbody2D.velocity = Vector2.up * jumpPower;
    }

    //If bird collied something game over.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManagement.Instance.GameOver();
    }
}
