using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HoverObj : MonoBehaviour
{
    public GameObject inspection;
    public InspectionObj InspectionObj;
    public int index;
    public Text text;
    private void Update()
    {
        Ray ray = Camera.main.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (GetComponent<Collider>().Raycast(ray, out hit, 3f))
        {
            text.text = "[E]";
            if (Input.GetKeyDown(KeyCode.E))
            {
                inspection.SetActive(true);
                InspectionObj.TurnOnInspection(index);
            }
        }
        else
        {
            text.text = "";
        }
        
    }
}
