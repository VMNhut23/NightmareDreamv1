using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CofferController : MonoBehaviour
{
    private Animator cofferAim;
    private bool cofferOpen = false;
    public UnityEvent unityEvent;

    private void Awake()
    {
        cofferAim = GetComponent<Animator>();
    }

    public void Interact()
    {
        unityEvent?.Invoke();
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
