using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnOffFl : MonoBehaviour
{
    public GameObject flashlight;
    public Text text;

    void Start()
    {
        flashlight.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            text.text = "Press X to use flashligh, C to on/off ";
            StartCoroutine(End());
        }
    }
    IEnumerator End()
    {
        yield return new WaitForSeconds(3f);
        text.text = "";
        Destroy(gameObject);
        flashlight.SetActive(true);
    }
}
