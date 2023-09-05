using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;

public class ChangeScene : MonoBehaviour
{
    public TimelineClip timelineClip;
    private void OnEnable()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }
}
