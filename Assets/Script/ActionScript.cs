using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionScript : MonoBehaviour
{
    public bool isTouched;

    public SpriteRenderer sprite;


    public void Update()
    {

        if (isTouched)
            sprite.color = Color.red;


    }



}
