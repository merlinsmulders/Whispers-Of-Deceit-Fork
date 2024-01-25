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
    public Animator doorAni;
    public Animator monsterAni;
    public DoorOpenscript doorOpen;
    public AudioSource monsterAudio;
    public AudioClip monsterWalk;
    public AudioClip monsterBreaking;
    public AudioClip monsterBreathing;
    public void Update()
    {
        if (Physics.CheckSphere(transform.position, sphereRadius, layerMask))
        {
            if(eventPlaying)
            {
                selectTool.SetActive(true);
                selectTool2.SetActive(true);
                StartCoroutine(StartEvent());
                eventPlaying = false;
            }
        }
        else
        {
            selectTool.SetActive(false);
            selectTool2.SetActive(false);
        }
    }
    public IEnumerator StartEvent()
    {
        yield return new WaitForSeconds(10);
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
    }
    public void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, sphereRadius);
        Gizmos.color = Color.cyan;
    }
}
