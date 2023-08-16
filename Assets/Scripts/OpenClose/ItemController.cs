using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemController : MonoBehaviour
{
    public UnityEvent onClick;
    public void OnClick()
    {
        onClick?.Invoke();
    }
}
