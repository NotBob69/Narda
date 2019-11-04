using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetTapping : MonoBehaviour
{

    private ActionScript action;
    private PetStats petStats;

    // Start is called before the first frame update
    void Start()
    {
        action = gameObject.GetComponent<ActionScript>();
        petStats = GameObject.Find("Gameplay manager").GetComponent<PetStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (action.isTouched) {
            petStats.petTapping++;
            action.isTouched = false;

        }
        
        
    }
}
