using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hiding : MonoBehaviour
{
    Vector3 oldPlayerPos;
    public GameObject player;
    public GameObject target;
    public BoxCollider triggerActivator;
    public AudioSource monsterAudio;
    public AudioSource sideSFX;
    public AudioSource footsteps;
    public Animator monsterCart;
    bool audioPlayed;
    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Hide")
        {
            if(!audioPlayed)
            {
                monsterAudio.Play();
                monsterCart.SetTrigger("StartEvent");
                StartCoroutine(StopHiding());
                StartCoroutine(BreakingSound());
                footsteps.Stop();
                oldPlayerPos = player.transform.position;
                player.transform.rotation = Quaternion.Euler(0, 180, 0);
                player.transform.position = target.transform.position;
                player.GetComponent<OVRPlayerController>().enabled = false;
                triggerActivator.enabled = false;
                audioPlayed = true;
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
    public IEnumerator BreakingSound()
    {
        yield return new WaitForSeconds(3.5f);
        sideSFX.Play();
    }
}
