using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    private AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        StartCoroutine(WaitAudioPriority());
    }

    IEnumerator WaitAudioPriority()
    {
        yield return new WaitForSeconds(4.5f);
        audioSrc.priority = 50;
    }
}
