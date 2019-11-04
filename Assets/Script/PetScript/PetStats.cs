using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetStats : MonoBehaviour
{
    // hunger and cleanless should change more than happiness and health, maybe make separate tick that counts when health and happiness changes
    // should save pet stats atleast to playerprefs for now, maybe
    public float happiness = 100;  // happiness should increase afther cockroach minigame
    public float cleanless = 100; // cleanless should increase afther cleaning minigame/activity
    public float hunger = 100;
    public float health = 100;

    // needs to save on player data
    public float xp = 0;
    public int currentLevel = 1;
    public float xpTillNextLevel;
    public bool gainedXp = false; // kai duodi xp kad pasikeistu xp bar
    public bool levelUp = false; // kai pasieki nauja leveli
    public ChangePetText text;

    // achievment stats
    public int pestKilled = 0;
    public bool haveReachedMax;
    public bool haveDied;
    public bool cleaningDead= false;
    public int petTapping=0;


    // change to private when done testing
    public float baseTick = 180;
    public float tickTimer;

    private bool changedXp = false;
    public bool alive = true;

    // Start is called before the first frame update
    void Awake()
    {
        xpTillNextLevel = (25 * (currentLevel+1) * (1 + (currentLevel + 1)));
        tickTimer = baseTick;
        UpdateStats();
        CalculateXp();
        text.ChangeText(text.levelTxt, currentLevel);
    }

    // Update is called once per frame
    void Update()
    {
        tickTimer -= Time.deltaTime;

        if (tickTimer <= 0) {

            hunger--;
            cleanless--;

            CalculateHealth();
            tickTimer = baseTick;
            UpdateStats();
        }
        if (changedXp)
        {
            gainedXp = true;
            changedXp = false;
            CalculateXp();
        }
        if (health <= 0)
        {
            alive = false;
            haveDied = true;
        }
        if (currentLevel == 15)
            haveReachedMax = true;

    }

    public void UpdateStats() {

        text.ChangePetStatsTxt(health, cleanless, hunger, happiness);

    }
    public float StatsAvarge() {

        return (happiness + health + cleanless + hunger) / 4;
    }

    private void CalculateHealth() {

        if (hunger >= 75 && cleanless >= 75)
            return;
        
        health -= (100 - ((hunger + cleanless) / 2))*0.1f;

    }

    private void CalculateXp() {

        if (xpTillNextLevel <= xp)
        {
            currentLevel++;
            text.ChangeText(text.levelTxt, currentLevel);

            xpTillNextLevel = (25 * (currentLevel + 1) * (1 + (currentLevel + 1)));
            xp = 0;
            levelUp = true;
            
        }
    }

    public void GiveXp(float ammount) {

        xp += ammount;
        gainedXp = true;
        CalculateXp();
    }

    public void _GETXP() {

        xp += 50;

        changedXp = true;

    }

    


}
