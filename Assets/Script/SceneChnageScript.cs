using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneChnageScript : MonoBehaviour
{
    public FadeScript fadeScript;
    public SaveLoudScript saveLoudScript;

    public void CloseGame()
    {
        StartCoroutine(Delay("quit", -1, ""));

    }
    public IEnumerator Delay(string command, int character, string name)
    {
        if (string.Equals(command, "quit", StringComparison.OrdinalIgnoreCase))
        {
            yield return fadeScript.FadeIn(0.1f);
            PlayerPrefs.DeleteAll();

            if (UnityEditor.EditorApplication.isPlaying)
            {
                UnityEditor.EditorApplication.isPlaying = false;
            }
            else
            {
                Application.Quit();
            }
        }else if(string.Equals(command, "play", StringComparison.OrdinalIgnoreCase))
        {
            yield return fadeScript.FadeIn(0.1f);
            saveLoudScript.SaveGame(character, name);
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
    }
}
