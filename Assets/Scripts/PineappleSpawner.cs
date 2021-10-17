using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PineappleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject spawn;
    [SerializeField] private float x, y;
    [SerializeField] private float setTimer;

    private float timer = 0.0f;

    // Update is called once per frame
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
