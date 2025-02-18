using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ChooseCharecterScript : MonoBehaviour
{
    public GameObject[] charecters;
    int charecterIndex;
    public GameObject inputField;
    string charecterName;
    public int playerCount = 7;
    public SceneChnageScript sceneChnageScript;
    void Awake()
    {
        charecterIndex = 0;
        foreach(GameObject charecter in charecters)
        {
            charecter.SetActive(false);
        }
        charecters[charecterIndex].SetActive(true);
    }

    public void NextCharecter()
    {
        charecters[charecterIndex].SetActive(false);
        charecterIndex++;
        if(charecterIndex == charecters.Length)
        {
            charecterIndex = 0;
        }
        charecters[charecterIndex].SetActive(true);
    }

    public void PreviousCharecter()
    {
        charecters[charecterIndex].SetActive(false);
        charecterIndex--;
        if (charecterIndex == -1)
        {
            charecterIndex = charecters.Length-1;
        }
        charecters[charecterIndex].SetActive(true);
    }

    public void Play()
    {
        charecterName = inputField.GetComponent<TMP_InputField>().text;
        if (charecterName.Length > 2)
        {
            PlayerPrefs.SetInt("SelectedCharecter", charecterIndex);
            PlayerPrefs.SetString("PlayerName", charecterName);
            PlayerPrefs.SetInt("PlayerCount", playerCount);
            StartCoroutine(sceneChnageScript.Delay("play", charecterIndex, charecterName));
        } else
            inputField.GetComponent<TMP_InputField>().Select();


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
