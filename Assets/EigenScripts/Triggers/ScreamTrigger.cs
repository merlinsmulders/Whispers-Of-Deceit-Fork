using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreamTrigger : MonoBehaviour
{
    public AudioSource screamAudio;
    public float sphereRadius;
    public LayerMask layerMask;
    bool audioHasPlayed;
    public void Update()
    {
        if (Physics.CheckSphere(transform.position, sphereRadius, layerMask))
        {
            if (!screamAudio.isPlaying)
            {
                if(!audioHasPlayed)
                {
                    screamAudio.Play();
                    audioHasPlayed = true;
                }
            }
        }
    }
    public void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, sphereRadius);
        Gizmos.color = Color.cyan;
    }
}
