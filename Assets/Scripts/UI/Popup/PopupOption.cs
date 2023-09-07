using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupOption : BasePopup
{
    public override void Show(object data)
    {
        base.Show(data);
    }

    public override void Hide()
    {
        base.Hide();
    }
    public void OnClickButtonAudio()
    {
        if (UIManager.HasInstance)
        {
            UIManager.Instance.ShowPopup<PopupAudio>();
        }
    }
}
