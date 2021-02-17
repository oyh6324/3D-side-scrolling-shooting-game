using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private InputKey inputKey;
    private Rigidbody rigidbody;

    public float speed ;
    public float jumpSpeed;
    private float currentJumpY;

    private bool jumping;
    private void Awake()
    {
        inputKey = GetComponent<InputKey>();
        rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        var preY = rigidbody.velocity.y;
        rigidbody.velocity = new Vector2(inputKey.horizonAxis * speed, preY);
        if (inputKey.jump && !jumping)
        {
            rigidbody.AddForce(Vector2.up * jumpSpeed, ForceMode.Impulse);
            jumping = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Ground")
        {
            jumping = false;
        }
    }
}
