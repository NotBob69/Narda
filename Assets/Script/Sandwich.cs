using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sandwich : MonoBehaviour
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
            GameObject.Find("Gameplay manager").GetComponent<PetStats>().hunger += 10;
        }
    }
}
