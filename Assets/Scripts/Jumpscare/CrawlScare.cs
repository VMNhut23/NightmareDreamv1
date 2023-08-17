using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrawlScare : MonoBehaviour
{
    public GameObject crawl;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            crawl.SetActive(true);
            StartCoroutine(EndScare());
        }
    }
    IEnumerator EndScare()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
        Destroy(crawl);
    }
}
