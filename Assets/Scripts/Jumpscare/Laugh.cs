using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laugh : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (AudioManager.HasInstance)
            {
                AudioManager.Instance.PlaySE(AUDIO.SE_SE_LAUGH);
            }
            StartCoroutine(Destroy());
        }
    }
    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
