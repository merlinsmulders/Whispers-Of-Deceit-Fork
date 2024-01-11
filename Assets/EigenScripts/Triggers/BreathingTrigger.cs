using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreathingTrigger : MonoBehaviour
{
    public AudioSource monsterbreathing;
    public float sphereRadius;
    public LayerMask layerMask;
    public void Update()
    {
        if (Physics.CheckSphere(transform.position, sphereRadius, layerMask))
        {
            if(!monsterbreathing.isPlaying)
            {
                monsterbreathing.Play();
            }
        }
        else
        {
            if(monsterbreathing.isPlaying)
            {
                monsterbreathing.Stop();
            }
        }
    }
    public void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, sphereRadius);
        Gizmos.color = Color.cyan;
    }
}
