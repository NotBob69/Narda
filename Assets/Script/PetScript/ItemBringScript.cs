using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBringScript : MonoBehaviour
{


    [SerializeField] private float itemTick;
    [SerializeField] private float baseTick = 100;
    private PetStats petStats;
    public List<ItemScript> lootedItems;


    private int itemID;

    // Start is called before the first frame update
    void Start()
    {
        itemID = 0; // kai bus item database sita fix
        itemTick = baseTick;
        petStats = this.gameObject.GetComponent<PetStats>();
        
    }

    // Update is called once per frame
    void Update()
    {
        itemTick -= Time.deltaTime;
        if(itemTick <= 0)
        {
            BringItems();

        }

        
    }

    private void BringItems()
    {
        // perdaryti sita kai bus item database
       // bool healthItems = false;
        bool junkItems = false;
        bool goodItems = false;
        bool healthItems = false;
        bool foodItems = false;


        float statAvg = petStats.StatsAvarge();

        if (petStats.hunger < 50)
            foodItems = true;

        if (petStats.health < 50)
            healthItems = true;

        if (statAvg > 50)
        {
            goodItems = true;
            lootedItems.Add(new ItemScript(itemID,ItemScript.ItemType.loot,100f));

        }
        else
        {
            junkItems = true;
            lootedItems.Add(new ItemScript(itemID, ItemScript.ItemType.junk, 0f)); 

        }

        itemID++;
        itemTick = baseTick;


    }
}
