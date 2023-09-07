using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenGame : BaseScreen
{
    public override void Show(object data)
    {
        base.Show(data);
    }

    public override void Hide()
    {
        base.Hide();
    }
    public void Resume()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            this.Hide();
            if (UIManager.HasInstance)
            {
                UIManager.Instance.ShowPopup<PopupSetting>();
                
            }
            
        }
    }
}
