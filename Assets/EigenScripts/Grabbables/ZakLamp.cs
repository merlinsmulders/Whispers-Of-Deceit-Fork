using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class ZakLamp : MonoBehaviour
{
    public GameObject SpotLight;
    bool lightActive;
    bool canSwitch;
    public AudioSource lightSwitchsound;

    public void Update()
    {
        FlashLight();
    }
    public void FlashLight()
    {
        if(canSwitch)
        {
            if (!lightActive)
            {
                if (OVRInput.GetDown(OVRInput.Button.One))
                {
                    SpotLight.SetActive(true);
                    lightActive = true;
                    lightSwitchsound.Play();
                }
            }
            else
            {
                if (OVRInput.GetDown(OVRInput.Button.One))
                {
                    SpotLight.SetActive(false);
                    lightActive = false;
                    lightSwitchsound.Play();
                }
            }
        }
    }
    public void FlashLightOn()
    {
        canSwitch = true;
    }
    public void FlashLightOff()
    {
        canSwitch = false;
    }
}
