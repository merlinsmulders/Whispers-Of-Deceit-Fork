using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBackInMenu : MonoBehaviour
{
    public Collider handCollider;
    public GameObject Player;
    public GameObject selectTool;
    public GameObject selectTool2;
    Vector3 mainMenuPos;
    public void Start()
    {
        mainMenuPos = new Vector3(-6.45f, 1f, 0.5f);
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "UI")
        {
            Player.transform.position = mainMenuPos;
            Player.GetComponent<OVRPlayerController>().enabled = false;
            handCollider.enabled = false;
            selectTool.SetActive(true);
            selectTool2.SetActive(true);
        }
    }
}
