using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    private Animator anim;

    [SerializeField] private GameObject player;
    
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
        anim = GetComponent<Animator>();
        anim.SetBool("isDead", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Health.healthValue == 0)
        {
            anim.SetBool("isDead", true);
            StartCoroutine(WaitDestroy());

        }
    }

    IEnumerator WaitDestroy()
    {
        yield return new WaitForSeconds(1.0f);
        Destroy(this.gameObject);
    }

}
