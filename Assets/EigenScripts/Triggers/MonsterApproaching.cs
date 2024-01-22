using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterApproaching : MonoBehaviour
{
    public GameObject target;
    public GameObject playerCamera;
    public GameObject deathTarget;
    public GameObject selectTool;
    public GameObject selectTool2;
    public Animator appAnimator;
    public Animator doorAni;
    public AudioSource monsterwWalk;
    public AudioClip doorBanging;
    public AudioSource neckSnap;
    public DoorOpenscript doorOpen;
    bool alreadyPlayed;
    public void OnTriggerEnter(Collider other)
    {
        if(!alreadyPlayed)
        {
            if (other.transform.tag == "App")
            {
                Debug.Log("EventStart");
                StartCoroutine(WaitForAudio());
                doorOpen.enabled = false;
                doorAni.SetInteger("DoorOpens", 2);
                PlayerPrefs.SetFloat("playerposx", target.transform.position.x);
                PlayerPrefs.SetFloat("playerposy", target.transform.position.y);
                PlayerPrefs.SetFloat("playerposz", target.transform.position.z);
                alreadyPlayed = true;
            }
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
        StartCoroutine(DeathScreenActive());
    }
    public IEnumerator DeathScreenActive()
    {
        yield return new WaitForSeconds(5);
        Debug.Log(deathTarget.transform.position);
        transform.position = deathTarget.transform.position;
        playerCamera.transform.position = deathTarget.transform.position;
        Debug.Log(transform.position);
        doorOpen.enabled = true;
        monsterwWalk.Stop();
        neckSnap.Play();
        selectTool.SetActive(true);
        selectTool2.SetActive(true);
    }
}
