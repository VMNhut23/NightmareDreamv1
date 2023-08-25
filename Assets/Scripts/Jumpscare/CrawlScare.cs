using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrawlScare : MonoBehaviour
{
    public GameObject crawl;
    public AudioSource soundCrawl;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            soundCrawl.Play();
            crawl.SetActive(true);
            StartCoroutine(EndScare());
        }
    }
    IEnumerator EndScare()
    {
        yield return new WaitForSeconds(0.8f);
        soundCrawl.Pause();
        Destroy(gameObject);
        Destroy(crawl);
    }
}
