using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform [] spawnpoint;

    public GameObject coakroach;

    private GameObject pestData;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        //spawn random number of roaches min 1 max 5
         int roach = Random.Range(1, 5);
        

        for(int i = 0; i < roach; i++)
        {
            pestData = Instantiate(coakroach, spawnpoint[Random.Range(0, spawnpoint.Length)].position, new Quaternion(0,0,0,0));
            pestData.GetComponent<PestAI2>().waypoint = spawnpoint;
            
        }
    }
}
