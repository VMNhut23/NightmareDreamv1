using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScreenHome : BaseScreen
{
    private void OnEnable()
    {

    }

    public override void Init()
    {
        base.Init();
        if (AudioManager.HasInstance)
        {
            AudioManager.Instance.PlayBGM(AUDIO.BGM_BGM_01);
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

    public void OnClickPopupSetting()
    {
        if (UIManager.HasInstance)
        {
            UIManager.Instance.ShowPopup<PopupOption>();
        }
        this.Hide();
    }

    public void StartGame()
    {
        if (UIManager.HasInstance)
        {
            //UIManager.Instance.ShowNotify<NotifyLoadingGame>();
            GameManager.Instance.LoadScene("Main");
        }
        this.Hide();
    }
    public void EndGame()
    {
        Application.Quit();
    }
}