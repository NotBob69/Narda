using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageSpawner : MonoBehaviour
{

    public Transform[] spawnpoint;

    public GameObject garbageBag;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        

         int bag = Random.Range(1, 10);

           for (int i = 0; i < bag; i++ )
           {
               Instantiate(garbageBag, spawnpoint[Random.Range(0, spawnpoint.Length)].position, new Quaternion(0,0,0,0));
           }
    }
}
