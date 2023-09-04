using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OnOffFl : MonoBehaviour
{
    public GameObject flashlight;
    public TextMeshProUGUI text;

    void Start()
    {
        flashlight.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            text.text = "Press X to use flashlight" +
                        "\nPress C to on/off ";
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
