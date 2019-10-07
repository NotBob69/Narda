using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PestAi : MonoBehaviour
{
    public SpriteRenderer sprite;

    //finite state machine variables
    private Animator animator;
    public bool isStanding = false;
    public bool isMoving = false;
    public bool isDead = false;
    private float distanceFromTarget;
    private float distanceFromWaypoint;

    //pest movement and direction
    Vector3 direction;
    private float walkSpeed = 5f;
    private int currentTarget;
    private Transform[] waypoints = null;


    public void GetNewWayPoint()
    {
        animator = gameObject.GetComponent<Animator>();

        //adding viewpoints

        Transform view1 = GameObject.Find("viewpoint").transform;
        Transform view2 = GameObject.Find("viewpoint2").transform;
        Transform view3 = GameObject.Find("viewpoint3").transform;
        Transform view4 = GameObject.Find("viewpoint4").transform;
        Transform view5 = GameObject.Find("viewpoint5").transform;
        Transform view6 = GameObject.Find("viewpoint6").transform;
        Transform view7 = GameObject.Find("viewpoint7").transform;
        Transform view8 = GameObject.Find("viewpoint8").transform;

        waypoints = new Transform[8] {
            view1,
            view2,
            view3,
            view4,
            view5,
            view6,
            view7,
            view8
        };

    }

    public void Update()
    {

        if (isMoving)
        {
            RotatePest();
        }

        if (!isStanding)
        {
            transform.Translate(walkSpeed * direction * Time.deltaTime, Space.World);
        }

    }

    private void FixedUpdate()
    {
        //values for finite state machine
        distanceFromTarget = Vector3.Distance(waypoints[currentTarget].position, transform.position);
        animator.SetFloat("distanceFromWaypoint", distanceFromTarget);
        
    }

    public void MoveToNewWayPoint()
    {
        // Pick a random waypoint 
        int nextPoint = -1;

        do
        {
            nextPoint = Random.Range(0, waypoints.Length - 1);
        }
        while (nextPoint == currentTarget);

        currentTarget = nextPoint;

        // Load the direction of the next waypoint
        direction = waypoints[currentTarget].position - transform.position;
        RotatePest();

    }

    public void RotatePest()
    {
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
        direction = direction.normalized;
    }

    public void StealObject()
    {

    }

    public void GetsKilled()
    {

    }
}
