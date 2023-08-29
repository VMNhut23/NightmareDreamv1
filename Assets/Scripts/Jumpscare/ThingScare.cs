using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThingScare : MonoBehaviour
{
    public GameObject thingScare;      
    public Text text;

    void Update()
    {
        Ray ray = Camera.main.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (GetComponent<Collider>().Raycast(ray, out hit, 3f))
        {
            if (text != null)
            {
                text.text = "[E]";
            }
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                thingScare.SetActive(true);
                StartCoroutine(End());
            }
        }
        else
        {
            if (text != null)
            {
                text.text = "";
            }
            
        }
    }
    IEnumerator End()
    {
        yield return new WaitForSeconds(5f);
        thingScare.SetActive(false);
        Destroy(gameObject);
    }
}
