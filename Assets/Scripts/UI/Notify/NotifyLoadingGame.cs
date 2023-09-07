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
        async = SceneManager.LoadSceneAsync("Main");
        loadingIcon.SetActive(true);
        loadingInfo.SetActive(false);
        yield return true;
        async.allowSceneActivation = false;
        loadingIcon.SetActive(false);
        loadingInfo.SetActive(true);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            async.allowSceneActivation = true;
        }
    }
}
