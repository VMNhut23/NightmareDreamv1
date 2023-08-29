using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour
{
    public AudioSource kill;
    public Light flickerLight;
    public GameObject decal;
    public GameObject blood;
    public GameObject monsterHead;

    public float minSpeed = 0.1f;
    public float maxSpeed = 0.5f;

    public float minIntensity = 0.01f;
    public float maxIntensity = 0.2f;
    void Start()
    {
        flickerLight = GetComponent<Light>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            kill.Play();
            decal.SetActive(true);
            blood.SetActive(false);
            monsterHead.SetActive(true);
            StartCoroutine(Run());
        }
    }
    IEnumerator Run()
    {
        while (true)
        {
            flickerLight.enabled = true;
            flickerLight.intensity = Random.Range(minIntensity, maxIntensity);
            yield return new WaitForSeconds(Random.Range(minSpeed, maxSpeed));
            flickerLight.enabled = false;
            yield return new WaitForSeconds(Random.Range(minSpeed, maxSpeed));
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            kill.Pause();
            blood.SetActive(true);
            monsterHead.SetActive(false);
            StartCoroutine(End());
        }
    }
    IEnumerator End()
    {
        yield return new WaitForSeconds(0.1f);
        decal.SetActive(false);
        Destroy(gameObject);
    }
}
