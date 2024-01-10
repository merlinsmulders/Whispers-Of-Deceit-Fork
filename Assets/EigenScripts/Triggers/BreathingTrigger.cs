using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreathingTrigger : MonoBehaviour
{
    public AudioSource monsterbreathing;
    public void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            monsterbreathing.Play();
        }
    }
}
