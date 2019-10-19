using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class XpBar : MonoBehaviour
{

    public Slider xpBar;
    public PetStats petStats;




    private void Start()
    {
        xpBar.maxValue = petStats.xpTillNextLevel;

        
    }


    public void LateUpdate()
    {
        if (petStats.levelUp) {
            xpBar.maxValue = petStats.xpTillNextLevel;
            xpBar.value = 0;
            petStats.levelUp = false;

        }

        if (petStats.gainedXp) {
            xpBar.value = petStats.xp;
            petStats.gainedXp = false;

        }

    }






}
