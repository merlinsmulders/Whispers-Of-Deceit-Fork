using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LijkWeg : MonoBehaviour
{
    public Animator animator;
    public float sphereRadius;
    public LayerMask layerMask;
    public AudioSource sFX;
    public AudioClip victim;
    public AudioClip monster;
    bool audioPlayed;


    public void Update()
    {
        if (Physics.CheckSphere(transform.position, sphereRadius, layerMask))
        {
            animator.SetInteger("LijkWeg", 1);
            if(!audioPlayed)
            {
                sFX.clip = victim;
                sFX.Play();
                StartCoroutine(NextSFX());
                audioPlayed = true;
            }
        }
    }
    public IEnumerator NextSFX()
    {
        yield return new WaitForSeconds(5);
        sFX.clip = monster;
        sFX.Play();
    }
    public void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, sphereRadius);
        Gizmos.color = Color.cyan;
    }
}
