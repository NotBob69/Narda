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

    public ChangePetText text;

    // change to private when done testing
    public float baseTick = 180;
    public float tickTimer;


    // Start is called before the first frame update
    void Start()
    {
        tickTimer = baseTick;
        UpdateStats();

    }

    // Update is called once per frame
    void Update()
    {
        tickTimer -= Time.deltaTime;

        if (tickTimer <= 0) {

            hunger--;
            cleanless--;

            CalculateHealth();
            CalculateHappyness();
            tickTimer = baseTick;
            UpdateStats();



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

   

    private void CalculateHappyness() {
       

    }
}
