using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject spawn;
    [SerializeField] private float setTimer;
    [SerializeField] private float x, y;

    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer > setTimer)
        {
            timer = 0;
            Instantiate(spawn, new Vector3(x, y, 0), Quaternion.identity);
        }
    }
}
