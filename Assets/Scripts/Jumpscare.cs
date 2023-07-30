using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject jumpScare;
    public GameObject scare;

    private void OnTriggerEnter()
    {
        {
            mainCam.SetActive(false);
            jumpScare.SetActive(true);
            Destroy(scare);
            StartCoroutine(EndJumpScare());
        }
    }
    IEnumerator EndJumpScare()
    {
        yield return new WaitForSeconds(2f);
        mainCam.SetActive(true);
        jumpScare.SetActive(false);
        Destroy(gameObject);
    }
}
