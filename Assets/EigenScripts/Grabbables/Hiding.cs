using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hiding : MonoBehaviour
{
    public Vector3 oldPlayerPos;
    public GameObject player;
    public GameObject target;
    public BoxCollider triggerActivator;
    public AudioSource monsterAudio;
    bool audioPlayed;
    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Hide")
        {
            oldPlayerPos = player.transform.position;
            player.transform.position = target.transform.position;
            player.GetComponent<OVRPlayerController>().enabled = false;
            triggerActivator.enabled = false;
            if(!audioPlayed)
            {
                monsterAudio.Play();
                StartCoroutine(StopHiding());
            }
        }
    }
    public IEnumerator StopHiding()
    {
        yield return new WaitForSeconds(17);
        monsterAudio.Stop();
        player.transform.position = oldPlayerPos;
        player.GetComponent<OVRPlayerController>().enabled = true;
        triggerActivator.enabled = true;
    }
}
