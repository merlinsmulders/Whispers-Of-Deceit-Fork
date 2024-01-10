using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    CharacterController controller;
    public AudioSource footSteps;
    void Start()
    {
        controller.GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        if (controller.velocity.magnitude > 0.5)
        {
            footSteps.Play();
        }
        else
        {
            footSteps.Stop();
        }
    }
}
