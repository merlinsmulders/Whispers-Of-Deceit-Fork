using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlay : MonoBehaviour
{
    public Collider handCollider;
    public GameObject player;
    public GameObject selectTool;
    public GameObject selectTool2;
    public void StartPlay()
    {
        player.GetComponent<OVRPlayerController>().enabled = true;
        selectTool.SetActive(false); 
        selectTool2.SetActive(false);
        handCollider.enabled = true;
    }
}
