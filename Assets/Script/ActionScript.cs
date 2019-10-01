using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionScript : MonoBehaviour
{
    public bool isTouched;

    public SpriteRenderer sprite; // just for testing


    public void Update()
    {
        // just for testing
        if (isTouched)
            sprite.color = Color.red;


    }



}
