using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedingScript : MonoBehaviour
{


    // reikes padaryti kad panaikinti maista 
    public void FeedPet()
    {
								FindObjectOfType<AudioManager>().Play("feeding_pet");

        this.gameObject.GetComponent<PetStats>().health = 100;
        this.gameObject.GetComponent<PetStats>().UpdateStats();
   

    }



}
