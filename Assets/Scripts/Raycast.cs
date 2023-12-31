using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Raycast : MonoBehaviour
{
    [SerializeField] private int rayLength = 5;
    [SerializeField] private LayerMask layerMaskInteract;
    [SerializeField] private string excludeLayerName = null;
    [SerializeField] private Image crosshair; 
    [SerializeField] private KeyCode openCoffer = KeyCode.E;

    private ItemController raycastObj;
    private bool isCrosshairActive;
    private bool doOnce;

    private const string interactableTag = "InteractiveObjectOpenClose";

    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | layerMaskInteract.value;

        if (Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
        {
            if (hit.collider.CompareTag(interactableTag))
            {
                if (!doOnce)
                {
                    raycastObj = hit.collider.gameObject.GetComponent<ItemController>();
                    CrosshairChange(true);  
                }
                isCrosshairActive = true;
                doOnce = true;

                if (Input.GetKeyDown(openCoffer))
                {
                    if (raycastObj != null)
                    {
                        raycastObj.OnClick();
                    }
                    
                }
            }
        }
        else
        {
            if (isCrosshairActive)
            {
                CrosshairChange(false);
                doOnce = false;
            }
        }
    }
    private void CrosshairChange(bool on)
    {
        if (on && !doOnce)
        {
            crosshair.color = Color.red;
        }
        else
        {
            crosshair.color = Color.white;
            isCrosshairActive = false;
        }
    }
}
