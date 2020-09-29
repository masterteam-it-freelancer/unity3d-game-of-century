using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn_script_Play : MonoBehaviour
{
    private AsyncOperation progress;
    public void navigationToPlayGameScene(string sceneName)
    {
        progress = SceneManager.LoadSceneAsync(sceneName);
    }

    private void Update()
    {
        if (progress != null)
        {
            Debug.Log(progress.progress);

        }
    }
}
