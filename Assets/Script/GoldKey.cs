using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldKey : MonoBehaviour
{

   

   public void Use()
    {

    }

    public void IsUsed()
    {
        Destroy(this.gameObject);

    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Chest"))
        {
            IsUsed();


        }

    }



}
