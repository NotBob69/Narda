using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PestAI2 : MonoBehaviour
{

    public Transform[] waypoint;

    public Transform currentWaypoint;

    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        //Choose random spawnpoint
        int spawnpoint = Random.RandomRange(0, waypoint.Length);
        this.transform.position = waypoint[spawnpoint].position;

        //current location coordinate
        currentWaypoint = waypoint[spawnpoint];

    }

    void GetNewWayPoint()
    {

    }

    private void Move()
    {
        
    }

    void Die()
    {

    }
}
