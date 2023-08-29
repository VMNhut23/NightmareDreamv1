using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePic : MonoBehaviour
{
    public GameObject inspection;
    public InspectionObj InspectionObj;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            inspection.SetActive(false);
            InspectionObj.TurnOffInspection();
        }
    }
}
