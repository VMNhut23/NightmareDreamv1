using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectionObj : MonoBehaviour
{
    public GameObject[] inspectionObj;
    private int currIndex;
    public void TurnOnInspection(int index)
    {
        currIndex = index;
        inspectionObj[index].SetActive(true);
    }
    public void TurnOffInspection()
    {
        inspectionObj[currIndex].SetActive(false);
    }
}
