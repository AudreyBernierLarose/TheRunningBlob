using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    private CinemachineBasicMultiChannelPerlin cmPerlin;

    [SerializeField] private CinemachineVirtualCamera cmVCam;
    [SerializeField] private float intensity;

    private float intensityStop = 0.0f;

    private void Start()
    {
        cmPerlin = cmVCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        cmPerlin.m_AmplitudeGain = intensityStop;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            cmPerlin.m_AmplitudeGain = intensity;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")       
            cmPerlin.m_AmplitudeGain = intensityStop;   
    }
}
