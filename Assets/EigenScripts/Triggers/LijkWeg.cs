using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LijkWeg : MonoBehaviour
{
    public Animator animator;
    public float sphereRadius;
    public LayerMask layerMask;
    public AudioSource sFX;
    public AudioSource earPiece;
    public AudioClip victim;
    public AudioClip monster;
    public AudioClip labVoiceline;
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
        StartCoroutine(VoiceLine());
    }
    public IEnumerator VoiceLine()
    {
        yield return new WaitForSeconds(7.5f);
        earPiece.clip = labVoiceline;
        earPiece.Play();
    }
    public void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, sphereRadius);
        Gizmos.color = Color.cyan;
    }
}
