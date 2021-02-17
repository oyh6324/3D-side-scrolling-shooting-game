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
    private void Awake()
    {
        inputKey = GetComponent<InputKey>();
        rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector3(inputKey.horizonAxis * speed, 0f, 0f);
        if (inputKey.jump) currentJumpY = jumpSpeed;
        currentJumpY += Time.deltaTime * Physics.gravity.y;
    }
}
