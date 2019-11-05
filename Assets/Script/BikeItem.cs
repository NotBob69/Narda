using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<ActionScript>().isTouched)
        {
            Debug.Log("pressed");
            GameObject.Find("Gameplay manager").GetComponent<PetStats>().happiness += 5;
            GameObject.Find("Gameplay manager").GetComponent<PetStats>().UpdateStats();
            gameObject.GetComponent<ActionScript>().isTouched = false;
        }
    }
}
