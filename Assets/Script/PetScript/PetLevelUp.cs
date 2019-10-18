using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetLevelUp : MonoBehaviour
{


    public Sprite egg; // 1-3
    public Sprite chicken;// 3-6
    public Sprite cat; // 6-9
    public Sprite raven; // 9 -12
    public Sprite tornado; // 12-15
    public Sprite serpent;// 15++
    public Sprite dead;// if life reaches 0



    private GameObject pet;
    private PetStats petStats;
    private bool firstTime= true;

    // Start is called before the first frame update
    void Start()
    {
        petStats = gameObject.GetComponent<PetStats>();
        pet = GameObject.FindGameObjectWithTag("Pet");

    }

    // Update is called once per frame
    void Update()
    {

        if (petStats.alive)
            switch (petStats.currentLevel)
            {
                case 1:
                    pet.GetComponent<SpriteRenderer>().sprite = egg;
                    break;
                case 3:
                    pet.GetComponent<SpriteRenderer>().sprite = chicken;
                    break;
                case 6:
                    pet.GetComponent<SpriteRenderer>().sprite = cat;
                    break;
                case 9:
                    pet.GetComponent<SpriteRenderer>().sprite = raven;
                    break;
                case 12:
                    pet.GetComponent<SpriteRenderer>().sprite = tornado;
                    break;
                case 15:
                    pet.GetComponent<SpriteRenderer>().sprite = serpent;
                    break;
            }

        else
            pet.GetComponent<SpriteRenderer>().sprite = dead;
    }
}
