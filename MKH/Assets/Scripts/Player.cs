using System.ComponentModel;
using Unity.Mathematics;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    public float JumpSpeed = 5f;

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
        if (Input.GetKey(KeyCode.Space))
        {
            tempVel.y = JumpSpeed;
        }


        myRigidbody.linearVelocity = tempVel;
    }
}
