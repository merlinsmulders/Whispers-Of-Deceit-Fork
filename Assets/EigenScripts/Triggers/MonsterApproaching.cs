using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterApproaching : MonoBehaviour
{
    public Animator appAnimator;
    public AudioSource monsterwWalk;
    public AudioClip doorBanging;
    public DoorOpenscript doorOpen;
    //public GameObject deathScreen;
    public void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "App")
        {
            Debug.Log("EventStart");
            StartCoroutine(WaitForAudio());
        }
    }
    public IEnumerator WaitForAudio()
    {
        yield return new WaitForSeconds(10);
        StartCoroutine(MonsterWalkstoPlayer());
        doorOpen.enabled = false;
        monsterwWalk.Play();
        appAnimator.SetTrigger("StartApp");
        doorOpen.enabled = false;
        StartCoroutine(StopAudio());
    }
    public IEnumerator MonsterWalkstoPlayer()
    {
        yield return new WaitForSeconds(7);
    }
    public IEnumerator StopAudio()
    {
        yield return new WaitForSeconds(17);
        monsterwWalk.clip = doorBanging;
        monsterwWalk.Play();
        //deathScreen.SetActive(true);
    }
}
