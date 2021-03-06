using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float speed;

    private float stop = 0.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x + speed, transform.position.y);

        if (Health.healthValue == 0)
            speed = stop;
        
    }
}
