using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PestAI2 : MonoBehaviour { 

    [SerializeField]
    public Transform[] waypoint;

    public Transform currentWaypoint;
    public int waypointIndex = 0;

    //get new waypoint
    public bool entered;

    [SerializeField]
    float moveSpeed = 2f;

    void Start()
    {
        Spawn();
       
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Spawn()
    {
        //Choose random spawnpoint
        int spawnpoint = Random.Range(0, waypoint.Length);
        Debug.Log(waypoint[spawnpoint].position);
        this.transform.position = waypoint[spawnpoint].position;

        //current location coordinate
        currentWaypoint = waypoint[spawnpoint];


        transform.position = waypoint[spawnpoint].transform.position;
    }

    private void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position,
                                                waypoint[waypointIndex].transform.position,
                                                moveSpeed * Time.deltaTime);

        if (entered)
        {
            //waypointIndex += 1;
            waypointIndex = Random.Range(0, waypoint.Length);
            entered = false;
        }

        if (waypointIndex == waypoint.Length)
            waypointIndex = 0;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Im a roach");
        if (collision.gameObject.CompareTag("Viewpoint"))
        {
            entered = true;
        }
    }
}

    

