using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsMenuManager : MonoBehaviour
{

    public TMP_Dropdown ResDropDown;
    public Toggle FullScreenToggle;

    Resolution[] AllResolutions;
    bool IsFullScreen;
    int SelectedResolution;
   
    void Start()
    {
        IsFullScreen = true;
        AllResolutions = Screen.resolutions;

        List<String> resolutionsStringList = new List<String>();
        foreach (Resolutions res in AllResolutions)
        {
            resolutionsStringList.add(res.ToString());
        }

        ResDropDown.AddOptions(resolutionsStringList);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
