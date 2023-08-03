using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laugh : MonoBehaviour
{
    public GameObject deadBody;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            deadBody.SetActive(true);
        }
        StartCoroutine(EndJumpscare());
    }
    IEnumerator EndJumpscare()
    {
        yield return new WaitForSeconds(6f);
        deadBody.SetActive(false);
        Destroy(gameObject);
    }
}
