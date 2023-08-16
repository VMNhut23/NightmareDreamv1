using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DrawerController : MonoBehaviour
{
    private Animator drawerAim;
    private bool drawerOpen = false;

    private void Awake()
    {
        drawerAim = GetComponent<Animator>();
    }
    public void PlayAnimation()
    {
        if (!drawerOpen)
        {
            drawerAim.Play("DrawerOpen", 0, 0.0f);
            drawerOpen = true;
        }
        else
        {
            drawerAim.Play("DrawerClose", 0, 0.0f);
            drawerOpen = false;
        }
    }
}
