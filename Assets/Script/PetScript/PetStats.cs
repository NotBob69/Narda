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
    public int currentLevel;
    public float xpTillNextLevel;
    private int nextLevel = 2;

    public ChangePetText text;

    // change to private when done testing
    public float baseTick = 180;
    public float tickTimer;

    private bool changedXp = false;

    // Start is called before the first frame update
    void Start()
    {
        tickTimer = baseTick;
        UpdateStats();
        CalculateXp();
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
            changedXp = false;
            CalculateXp();
        }

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
            currentLevel++;

            xpTillNextLevel = ((nextLevel-1+300*(nextLevel-1)/7)/4);
    }

    public void _GETXP() {

        xp += 100;

        changedXp = true;

    }


}
