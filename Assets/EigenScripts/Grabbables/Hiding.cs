using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hiding : MonoBehaviour
{
    public Vector3 oldPlayerPos;
    public GameObject player;
    public GameObject target;
    public BoxCollider triggerActivator;
    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Hide")
        {
            oldPlayerPos = player.transform.position;
            player.transform.position = target.transform.position;
            player.GetComponent<OVRPlayerController>().enabled = false;
            triggerActivator.enabled = false;
            StartCoroutine(StopHiding());
        }
    }
    public IEnumerator StopHiding()
    {
        yield return new WaitForSeconds(5);
        player.transform.position = oldPlayerPos;
        player.GetComponent<OVRPlayerController>().enabled = true;
        triggerActivator.enabled = true;
    }
}
