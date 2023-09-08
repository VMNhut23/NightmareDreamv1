using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupExit : BasePopup
{
    public override void Show(object data)
    {
        base.Show(data);
    }
    public override void Hide()
    {
        base.Hide();
    }
    public void OnClickButtonYes()
    {
        if (UIManager.HasInstance)
        {
            UIManager.Instance.ShowScreen<ScreenHome>();
        }
        if (AudioManager.HasInstance)
        {
            AudioManager.Instance.PlaySE(AUDIO.SE_SE_CLICK);
        }
        this.Hide();
    }
    public void OnClickButtonNO()
    {
        if (UIManager.HasInstance)
        {
            UIManager.Instance.ShowPopup<PopupPause>();
        }
        if (AudioManager.HasInstance)
        {
            AudioManager.Instance.PlaySE(AUDIO.SE_SE_CLICK);
        }
        this.Hide();
    }
}
