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
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (UIManager.HasInstance)
            {
                UIManager.Instance.ShowPopup<PopupPause>();
            }
            this.Hide();
        }
    }
    
}
