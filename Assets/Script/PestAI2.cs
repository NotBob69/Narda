using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PestAI2 : MonoBehaviour
{

    [SerializeField]
    public Transform[] waypoint;

    public Transform currentWaypoint;
    public int waypointIndex = 0;

    public ActionScript touched;

    //get new waypoint
    public bool entered;

    //hit points
    public int hp;

    [SerializeField]
    float moveSpeed = 2f;
    //float moveSpeed;


    void Start()
    {
        Spawn();
        touched = gameObject.GetComponent<ActionScript>();


        hp = Random.Range(2, 15);
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (touched.isTouched)
        {
            squash();
            touched.isTouched = false;
        }
    }

    protected void LateUpdate()
    {
        //stop the sprite from rotating on a certain axis
        transform.localEulerAngles = new Vector3(0, 0, transform.localEulerAngles.z);


    }

    void Spawn()
    {
        //Choose random spawnpoint
        int spawnpoint = Random.Range(0, waypoint.Length);

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

        transform.LookAt(waypoint[waypointIndex].transform);

       // moveSpeed = Random.Range(2, 15);

        if (entered)
        {
            waypointIndex = Random.Range(0, waypoint.Length);

            while (currentWaypoint == waypoint[waypointIndex])
            {

                waypointIndex = Random.Range(0, waypoint.Length);

            }
            entered = false;
        }

        if (waypointIndex == waypoint.Length)

            waypointIndex = 0;

    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Viewpoint"))
        {
            entered = true;
            currentWaypoint = collision.transform;
        }
    }

    public void squash()
    {
        hp--;
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
