using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class RollerNumberScript : MonoBehaviour
{
    // Start is called before the first frame update
   
        DiceRollScript diceRollScript;
    [SerializeField]
    TMP_Text rolledNumberText;

  

    // Update is called once per frame
    void Awake()
    {
        diceRollScript = FindObjectOfType<DiceRollScript>();
    }

     void Update()
    {
        if (diceRollScript != null)
            if (diceRollScript.isLanded)
                rolledNumberText.text = diceRollScript.diceFaceNum;
            else
                rolledNumberText.text = "?";
        else
            Debug.LogError("DiceRollScript not found in a scene!");
    }
}
