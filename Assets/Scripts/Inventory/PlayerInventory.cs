using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        items.Add(item);
        Debug.Log("Added item: " + item.name);
    }
    public void RemoveItem(Item item)
    {
        items.Remove(item);
    }
}
