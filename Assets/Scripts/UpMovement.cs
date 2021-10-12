using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpMovement : MonoBehaviour
{
    [SerializeField] private float velocity;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Health.healthValue--;
            Score.scoreValue--;
            //Flashing animation.
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + velocity);
    }
}
