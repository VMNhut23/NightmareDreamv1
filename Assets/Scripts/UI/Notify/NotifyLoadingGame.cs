using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class NotifyLoadingGame : BaseNotify
{
    public GameObject loadingInfo, loadingIcon;
    private AsyncOperation async;
    public override void Init()
    {
        base.Init();
        StartCoroutine(LoadScene());
    }

    public override void Show(object data)
    {
        base.Show(data);
    }

    public override void Hide()
    {
        base.Hide();
    }

    private IEnumerator LoadScene()
    {
        yield return null;
        async = SceneManager.LoadSceneAsync("Main");
        loadingIcon.SetActive(true);
        loadingInfo.SetActive(true);
        async.allowSceneActivation = false;

        yield return new WaitForSeconds(5f);
        loadingIcon.SetActive(false);
        loadingInfo.SetActive(true);
        async.allowSceneActivation = true;
        if (UIManager.HasInstance)
        {
            UIManager.Instance.ShowOverlap<OverlapFade>();
        }
        this.Hide();

    }
}
