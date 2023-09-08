using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupPause : BasePopup
{
    public override void Init()
    {
        base.Init();
        if (AudioManager.HasInstance)
        {
            AudioManager.Instance.PlayBGM(AUDIO.BGM_BGM_MAIN);
        }
    }
    public override void Show(object data)
    {
        base.Show(data);
    }

    public override void Hide()
    {
        base.Hide();
    }
    public void ResumeGame()
    {
        if (UIManager.HasInstance)
        {
            UIManager.Instance.ShowScreen<ScreenGame>();
        }
        if (AudioManager.HasInstance)
        {
            AudioManager.Instance.PlaySE(AUDIO.SE_SE_CLICK);
        }
        this.Hide();
    }
    public void OnClickButtonOption()
    {
        if (UIManager.HasInstance)
        {
            UIManager.Instance.ShowPopup<PopupAudio>();
        }
        if (AudioManager.HasInstance)
        {
            AudioManager.Instance.PlaySE(AUDIO.SE_SE_CLICK);
        }
        this.Hide();
    }
    public void OnClickButtonMenu()
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
    public void OnClickButtonExit()
    {
        if (UIManager.HasInstance)
        {
            UIManager.Instance.ShowPopup<PopupExit>();
        }
        if (AudioManager.HasInstance)
        {
            AudioManager.Instance.PlaySE(AUDIO.SE_SE_CLICK);
        }
        this.Hide();
    }
}
