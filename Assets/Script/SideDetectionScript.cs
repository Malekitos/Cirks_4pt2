using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SideDetectionScript : MonoBehaviour
{
    DiceRollScript diceRollScript;

    private void Awake()
    {
        diceRollScript = FindObjectOfType<DiceRollScript>();

    }

    private void OnTriggerStay(Collider sideCollider)
    {
        if (diceRollScript != null)
            if (diceRollScript.GetComponent<Rigidbody>().velocity == Vector3.zero)
            {
                diceRollScript.isLanded = true;
                diceRollScript.diceFaceNum = sideCollider.name;

            }
            else
                diceRollScript.isLanded = false;

        else
            Debug.LogError("DiceRollScript is not found");
    }

   
}
