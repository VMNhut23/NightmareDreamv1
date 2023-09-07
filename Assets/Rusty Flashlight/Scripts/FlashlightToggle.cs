using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class FlashlightToggle : MonoBehaviour
{
    public Animator flash;
    public GameObject lightGO; 
    private bool isOn = false; 

    void Start()
    {
        flash = GetComponent<Animator>();
        lightGO.SetActive(isOn);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            isOn = !isOn;
            if (isOn)
            {
                flash.Play("FlashOn", 0, 0.0f);
            }
            else
            {
                flash.Play("FlashOff", 0, 0.0f);
            }
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            isOn = !isOn;
            if (isOn)
            {
                lightGO.SetActive(true);
                if (AudioManager.HasInstance)
                {
                    AudioManager.Instance.PlaySE(AUDIO.SE_SE_FLASHLIGHT);
                }
            }
            else
            {
                lightGO.SetActive(false);
            }
        }
    }
}
