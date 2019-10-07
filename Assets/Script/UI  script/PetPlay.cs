using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetPlay : MonoBehaviour
{


    // reikes padaryti kad panaikinti maista 
    public void PlayWithPet()
    {
        this.gameObject.GetComponent<PetStats>().happiness = 100;
        this.gameObject.GetComponent<PetStats>().UpdateStats();
      

    }

}
