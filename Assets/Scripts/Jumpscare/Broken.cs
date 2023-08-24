using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broken : MonoBehaviour
{
    public GameObject plate;
    public GameObject broken_plate;
    public AudioSource soundScare;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            plate.SetActive(true);
            broken_plate.SetActive(true);
            soundScare.Play();
            StartCoroutine(EndTrigger());
        }
    }
    IEnumerator EndTrigger()
    {
        yield return new WaitForSeconds(3f);
        plate.SetActive(false);
        soundScare.Pause();
        Destroy(gameObject);
    }
    
}
