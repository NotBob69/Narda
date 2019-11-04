using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    void Update()
    {
        if (gameObject.GetComponent<ActionScript>().isTouched)
        {
            GameObject.Find("Gameplay manager").GetComponent<PetStats>().happiness += 5;
        }
    }
}
