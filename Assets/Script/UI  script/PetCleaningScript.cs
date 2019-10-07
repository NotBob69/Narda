using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetCleaningScript : MonoBehaviour
{



    public void CleanPet()
    {
        this.gameObject.GetComponent<PetStats>().cleanless = 100;
        this.gameObject.GetComponent<PetStats>().UpdateStats();
        
       


    }


}
