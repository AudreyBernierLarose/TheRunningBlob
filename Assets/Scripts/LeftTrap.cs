using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftTrap : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            Health.healthValue -= Health.healthValue;

        if (other.gameObject.tag == "Ball")
            Destroy(other.gameObject);
    }
}
