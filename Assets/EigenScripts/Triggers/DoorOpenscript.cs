using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenscript : MonoBehaviour
{
    public Animator animator;
    public float sphereRadius;
    public LayerMask layerMask;

    public void DoorOpensTrigger()
    {
        if(Physics.CheckSphere(transform.position, sphereRadius, layerMask))
        {
            animator.SetInteger("DoorOpens", 1);
        }
        else
        {
            animator.SetInteger("DoorOpens", 2);
        }
    }
    public void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, sphereRadius);
        Gizmos.color = Color.cyan;
    }
}
