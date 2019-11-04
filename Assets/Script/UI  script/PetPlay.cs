using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetPlay : MonoBehaviour
{


    // reikes padaryti kad panaikinti maista 
    public void PlayWithPet()
    {
		FindObjectOfType<AudioManager>().Play("playing_with_pet");

        this.gameObject.GetComponent<PetStats>().happiness = 100;
        this.gameObject.GetComponent<PetStats>().UpdateStats();
      

    }

}
