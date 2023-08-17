using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    [SerializeField] private bool door = false;
    [SerializeField] private bool key = false;

    [SerializeField] private KeyInventory keyInventory = null;

    private KeyDoorController doorObject;

    private void Start()
    {
        if (door)
        {
            doorObject = GetComponent<KeyDoorController>();
        }
    }
    public void ObjectInteraction()
    {
        if (door)
        {
            doorObject.PlayAnimation();
        }
        else if (key)
        {
            keyInventory.hasKey = true;
            gameObject.SetActive(false);
        }
    }
}
