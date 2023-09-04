using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objective : MonoBehaviour
{
    public GameObject theTrigger;
    public GameObject theObjective;
    public GameObject theText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(missionObj());
        }
    }
    IEnumerator missionObj()
    {
        theObjective.SetActive(true);
        theObjective.GetComponent<Animation>().Play("ObjDisplay");
        theText.GetComponent<Text>().text = "Minh dang o dau day";
        yield return new WaitForSeconds(5.3f);
        theText.GetComponent<Text>().text = "";
        theTrigger.SetActive(false);
        theObjective.SetActive(false);  
    }
}
