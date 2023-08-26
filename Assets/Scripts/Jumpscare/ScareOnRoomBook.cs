using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScareOnRoomBook : MonoBehaviour
{
    public Light lightScare;
    public GameObject obj;
    public Animator doorBook;
    public AudioSource soundRitual;
    private void OnTriggerEnter(Collider other)
    {
        obj.SetActive(true);
        doorBook.Play("DoorBookOff", 0, 0.0f);
        lightScare.enabled = true;
        soundRitual.Play();
        StartCoroutine(End());
    }
    IEnumerator End()
    {
        yield return new WaitForSeconds(10f);
        obj.SetActive(false);
        doorBook.Play("DoorBookOn", 0, 0.0f);
        lightScare.enabled = false;
        soundRitual.Pause();
        Destroy(gameObject);
    }
}
