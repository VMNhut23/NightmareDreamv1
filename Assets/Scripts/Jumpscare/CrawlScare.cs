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
            if (AudioManager.HasInstance)
            {
                AudioManager.Instance.PlaySE(AUDIO.SE_SE_JUMPSCARECRAWL);
            }
            crawl.SetActive(true);
            StartCoroutine(EndScare());
        }
    }
    IEnumerator EndScare()
    {
        yield return new WaitForSeconds(0.8f);
        Destroy(gameObject);
        Destroy(crawl);
    }
}
