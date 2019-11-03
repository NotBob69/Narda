using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PestCounter : MonoBehaviour
{
   // public GameObject roach;
    int numberOfPests;

    //text object variable
    [SerializeField] TextMeshProUGUI counter;

    void Start()
    {
        Update();
    }

    
    void Update()
    {
        numberOfPests = GameObject.FindGameObjectsWithTag("Pest").Length;

        counter.text = numberOfPests.ToString();
        
        //roach = GameObject.Find("CockRoach");
    }

  
}
