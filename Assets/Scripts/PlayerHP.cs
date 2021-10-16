using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    private Animator anim;
    private const float startHealth = 3.0f;
    private Rigidbody2D rBody;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hazard")
        {
            Health.healthValue--;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.SetBool("isDead", false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Health.healthValue < 0)
            Health.healthValue = 0f;

        if (Health.healthValue == 0)
        {
            rBody.constraints = RigidbodyConstraints2D.FreezeAll;
            anim.SetBool("isDead", true);
            StartCoroutine(WaitDestroy());
        }

        
    }

    IEnumerator WaitDestroy()
    {
        yield return new WaitForSeconds(3.0f);
        Destroy(this.gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Health.healthValue += startHealth;

    }
}
