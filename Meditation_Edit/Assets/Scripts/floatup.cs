using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class floatup : MonoBehaviour
{

    public float verticalSpeed;
    public float amplitude;
    private Vector3 tempPosition;

    private void Start()
    {
        tempPosition = transform.position;
    }

    private void FixedUpdate()
    {
        tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude;
        transform.position = tempPosition;
    }
}