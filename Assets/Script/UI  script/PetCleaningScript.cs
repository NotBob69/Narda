﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetCleaningScript : MonoBehaviour
{

    public GameObject sponge;
    public GameObject cleanButton;

    public bool isSpongeOut = false;

    public void CleanPet()
    {
 
        if(!isSpongeOut)
        Instantiate(sponge, cleanButton.transform.position,new Quaternion(0,0,0,0));

        isSpongeOut = true;


    }


}
