using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricalEvent : MonoBehaviour
{
    public float sphereRadius;
    public LayerMask layerMask;
    public GameObject selectTool;
    public GameObject selectTool2;
    public bool eventPlaying;
    public void Update()
    {
        if (Physics.CheckSphere(transform.position, sphereRadius, layerMask))
        {
            selectTool.SetActive(true);
            selectTool2.SetActive(true);
        }
        else
        {
            selectTool.SetActive(false);
            selectTool2.SetActive(false);
        }
    }
    public void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, sphereRadius);
        Gizmos.color = Color.cyan;
    }
}
