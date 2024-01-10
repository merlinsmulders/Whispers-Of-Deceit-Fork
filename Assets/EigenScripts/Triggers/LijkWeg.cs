using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LijkWeg : MonoBehaviour
{
    public Animator animator;
    public float sphereRadius;
    public LayerMask layerMask;

    public void Update()
    {
        if (Physics.CheckSphere(transform.position, sphereRadius, layerMask))
        {
            animator.SetInteger("LijkWeg", 1);
        }
    }
    public void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, sphereRadius);
        Gizmos.color = Color.cyan;
    }
}
