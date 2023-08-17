using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoorController : MonoBehaviour
{
    private Animator doorAim;
    private bool doorOpen = false;

    [Header("Animation Names")]
    [SerializeField] private string openAnimationnName = "DoorOpen";
    [SerializeField] private string closeAnimationnName = "DoorClose";

    [SerializeField] private int timeToShowUI = 1;
    [SerializeField] private GameObject showDoorLockedUI = null;

    [SerializeField] private KeyInventory keyInventory = null;

    [SerializeField] private int waitTimer = 1;
    [SerializeField] private bool pauseInteraction = false;

    private void Awake()
    {
        doorAim = gameObject.GetComponent<Animator>();
    }
    IEnumerator PauseDoorInteraction()
    {
        pauseInteraction = true;
        yield return new WaitForSeconds(waitTimer);
        pauseInteraction = false;
    }
    public void PlayAnimation()
    {
        if (keyInventory.hasKey)
        {
            if (!doorOpen && !pauseInteraction)
            {
                doorAim.Play(openAnimationnName, 0, 0.0f);
                doorOpen = true;
                StartCoroutine(PauseDoorInteraction());
            }
            else if (doorOpen && !pauseInteraction)
            {
                doorAim.Play(closeAnimationnName, 0, 0.0f);
                doorOpen = false;
                StartCoroutine(PauseDoorInteraction());
            }
            else
            {
                StartCoroutine(ShowDoorLocked());
            }
        }
    }
    IEnumerator ShowDoorLocked()
    {
        showDoorLockedUI.SetActive(true);
        yield return new WaitForSeconds(timeToShowUI);
        showDoorLockedUI.SetActive(false);
    }
}
