using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public Light myLight;
    public AudioSource humming;
    public float maxWait = 1;
    public float maxFlicker = 0.2f;
    float timer;
    float interval;
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > interval)
        {
            ToggleLight();
        }
    }
    void ToggleLight()
    {
        myLight.enabled = !myLight.enabled;
        if (myLight.enabled)
        {
            interval = Random.Range(0, maxWait);
            humming.Play();
        }
        else if (!myLight.enabled)
        {
            humming.Stop();
        }
        else
        {
            interval = Random.Range(0, maxFlicker);
        }

        timer = 0;
    }
}
