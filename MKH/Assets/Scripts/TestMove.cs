using System.ComponentModel;
using Unity.Mathematics;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Vector2 moveVelocity;
    private Rigidbody2D myRigidbody;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 tempVel = myRigidbody.linearVelocity;

        //move
        moveVelocity = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            moveVelocity.y = moveSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveVelocity.y = -moveSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveVelocity.x = -moveSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveVelocity.x = moveSpeed;
        }

        myRigidbody.linearVelocity = moveVelocity;
    }
}
