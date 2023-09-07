using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThingScare : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject scareCam;     
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
                text.text = "";
                mainCam.SetActive(false);
                scareCam.SetActive(true);
                StartCoroutine(End());
            }
        }
    }
    IEnumerator End()
    {
        yield return new WaitForSeconds(2f);
        mainCam.SetActive(true);
        scareCam.SetActive(false);
        
    }
}
