using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlay : MonoBehaviour
{
    public Animator openDoorAnimator;
    public AudioSource startDoorAudio;
    public AudioSource voiceLinesStart;
    public AudioClip firstVoice;
    public AudioClip secondVoice;
    public bool doorAlreadyOpened;
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
        if (!doorAlreadyOpened)
        {
            doorAlreadyOpened = true;
            PlayAudio();
        }
        else
        {

        }
    }
    public void PlayAudio()
    {
        voiceLinesStart.clip = firstVoice;
        voiceLinesStart.Play();
        StartCoroutine(PlaySecondAudio());
    }
    public IEnumerator PlaySecondAudio()
    {
        yield return new WaitForSeconds(8);
        voiceLinesStart.clip = secondVoice;
        voiceLinesStart.Play();
        startDoorAudio.Play();
        openDoorAnimator.SetInteger("DoorOpen", 1);
    }
}
