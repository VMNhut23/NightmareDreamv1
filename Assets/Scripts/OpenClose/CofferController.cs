using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofferController : MonoBehaviour
{
    private Animator cofferAim;
    private bool cofferOpen = false;

    private void Awake()
    {
        cofferAim = GetComponent<Animator>();
    }
    public void PlayAnimation()
    {
        if (!cofferOpen)
        {
            cofferAim.Play("CofferOpen", 0, 0.0f);
            cofferOpen = true;
        }
        else
        {
            cofferAim.Play("CofferClose", 0, 0.0f);
            cofferOpen = false;
        }
    }
}
