using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coffer : MonoBehaviour
{
    public float smooth = 2.0f;
    public TextMeshProUGUI text;
    public float CofferOpen;

    private Vector3 defaulPos;
    private Vector3 openPos;
    private bool isOpen, trig;

    private void Start()
    {
        defaulPos = transform.eulerAngles;
        openPos = new Vector3(defaulPos.x, defaulPos.y, defaulPos.z + CofferOpen);
    }

    public void Update()
    {
        OpenClose();
    }
    private void OpenClose()
    {
        if (isOpen)
        {
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openPos, Time.deltaTime * smooth);
        }
        else
        {
            transform.eulerAngles= Vector3.Slerp(transform.eulerAngles, defaulPos, Time.deltaTime * smooth);
        }
        if (Input.GetKeyDown(KeyCode.E) && trig)
        {
            isOpen = !isOpen;
        }
        if (trig)
        {
            if (isOpen)
            {
                text.text = "Close E";
            }
            else
            {
                text.text = "Open E";
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!isOpen)
            {
                text.text = "Close E";
            }
            else
            {
                text.text = "Open E";
            }
            trig = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            text.text = "";
            trig = false;
        }
    }
}
