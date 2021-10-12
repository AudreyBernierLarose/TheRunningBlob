using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Pineapple")
        {
            Debug.Log("In the destroyer function");
            Destroy(other.gameObject);
        }
    }
}
