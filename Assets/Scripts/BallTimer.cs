using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTimer : MonoBehaviour
{
    private Rigidbody2D rBody;
    private float velX;

    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        velX = Random.Range(-5f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(WaitDestroy());
    }

    IEnumerator WaitDestroy()
    {
        yield return new WaitForSeconds(10.0f);
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Level")
            rBody.velocity = new Vector3(velX, rBody.velocity.y, 0);

        if (collision.gameObject.tag == "Hazard")
            Destroy(this.gameObject);

        if (collision.gameObject.tag == "Player")
            Health.healthValue--;
    }
}
