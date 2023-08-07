using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AheadMansion : MonoBehaviour
{
    public TextMeshProUGUI text;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            text.text = "Troi mua roi tim cho chu an thoi";
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            text.text = "";
        }
    }
}
