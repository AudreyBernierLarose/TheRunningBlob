using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public static float healthValue = 3;
    Text health;

    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (healthValue > 3)
            healthValue = 3f;
        if (healthValue < 0)
            healthValue = 0f;

        health.text = " HP: " + healthValue;
    }
}
