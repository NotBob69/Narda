using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeItem : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<ActionScript>().isTouched)
        {

            GameObject.Find("Gameplay manager").GetComponent<PetStats>().GiveHappiness(5);
            gameObject.GetComponent<ActionScript>().isTouched = false;
        }
    }
}
