using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricalFix : MonoBehaviour
{
    public GameObject fixNowButton;
    public GameObject errorText;
    public GameObject systemFixedText;
    public Animator doorAni;
    public Animator monsterAni;
    public DoorOpenscript doorOpen;
    public AudioSource monsterAudio;
    public AudioSource earPiece;
    public AudioSource schermAudio;
    public AudioClip medicalEndVoiceLine;
    public AudioClip monsterWalk;
    public AudioClip monsterBreaking;
    public AudioClip monsterBreathing;
    public AudioClip progressSound;
    public AudioClip finishSound;
    public GameObject selectTool;
    public GameObject selectTool2;
    public ElectricalEvent electricalEvent;
    public void FixNow()
    {
        doorAni.SetInteger("DoorOpens", 2);
        doorOpen.enabled = false;
        monsterAni.SetTrigger("StartEvent");
        StartCoroutine(BreakingSound());
        StartCoroutine(BreakingSound());
        StartCoroutine(BreathingSound());
        StartCoroutine(MonsterWalking());
        StartCoroutine(StopEvent());
        monsterAudio.clip = monsterWalk;
        monsterAudio.Play();
        schermAudio.clip = progressSound;
        schermAudio.Play();
        fixNowButton.SetActive(false);
        electricalEvent.enabled = false;
        selectTool.SetActive(false);
        selectTool2.SetActive(false);
    }
    public IEnumerator BreakingSound()
    {
        yield return new WaitForSeconds(7);
        monsterAudio.clip = monsterBreaking;
        monsterAudio.Play();
    }
    public IEnumerator BreathingSound()
    {
        yield return new WaitForSeconds(12);
        monsterAudio.clip = monsterBreathing;
        monsterAudio.Play();
    }
    public IEnumerator MonsterWalking()
    {
        yield return new WaitForSeconds(24);
        monsterAudio.clip = monsterWalk;
        monsterAudio.Play();
    }
    public IEnumerator StopEvent()
    {
        yield return new WaitForSeconds(33);
        doorOpen.enabled = true;
        monsterAudio.Stop();
        earPiece.clip = medicalEndVoiceLine;
        earPiece.Play();
        errorText.SetActive(false);
        systemFixedText.SetActive(true);
        schermAudio.clip = finishSound;
        schermAudio.Play();
    }
}
