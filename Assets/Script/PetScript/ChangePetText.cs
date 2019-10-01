using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChangePetText : MonoBehaviour
{
    // maybe change to gameobject.find instead of putting manualy every text field atleast at start when everything changes often
    public TextMeshProUGUI healthTxt;
    public TextMeshProUGUI cleanlessTxt;
    public TextMeshProUGUI hungerTxt;
    public TextMeshProUGUI hapinessTxt;



    public void ChangePetStatsTxt(float health, float cleanless, float hunger, float hapiness) {

        healthTxt.text = health.ToString();
        cleanlessTxt.text = cleanless.ToString();
        hungerTxt.text = hunger.ToString();
        hapinessTxt.text = hapiness.ToString();
    }

    public void ChangeText(TextMeshProUGUI textField, float number)
    {
        textField.text = number.ToString();

    }


}
