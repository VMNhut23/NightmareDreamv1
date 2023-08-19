using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePic : MonoBehaviour
{
    public GameObject inspection;
    public InspectionObj InspectionObj;
    private Vector3 lastPos, currPos;
    private float rotationSpeed = -0.2f;

    private void Start()
    {
        lastPos = Input.mousePosition;
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            currPos = Input.mousePosition;
            Vector3 offset = currPos - lastPos;
            transform.RotateAround(transform.position, Vector3.up, offset.x * rotationSpeed);
        }
        lastPos = Input.mousePosition;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            inspection.SetActive(false);
            InspectionObj.TurnOffInspection();
        }
    }
}
