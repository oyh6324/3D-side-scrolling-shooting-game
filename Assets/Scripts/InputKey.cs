using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKey : MonoBehaviour
{
    public string horizontalKeyName;
    public string fireKeyName;
    public string jumpKeyName;

    public float horizonAxis { get; private set; }
    public bool fire { get; private set; }
    public bool jump { get; private set; }

    private void FixedUpdate()
    {
        horizonAxis = Input.GetAxis(horizontalKeyName);
        jump = Input.GetButtonDown(jumpKeyName);
        fire = Input.GetButtonDown(fireKeyName);
    }
}
