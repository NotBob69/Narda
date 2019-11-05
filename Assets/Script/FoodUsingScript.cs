using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodUsingScript : MonoBehaviour
{

    private ActionScript action;
    private PetStats petstats;

    // Start is called before the first frame update
    void Start()
    {
        action = gameObject.GetComponent<ActionScript>();
        petstats = GameObject.Find("Gameplay manager").GetComponent<PetStats>();
        
    }

    // Update is called once per frame
    void Update()
    {


        if (action.isTouched) {
            petstats.FeedPet(5);
            action.isTouched = false;

        }
        
    }
}
