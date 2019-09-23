using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{

    public GameObject[] screans;
    private GameObject currentScrean;
    public int currentWindow;
    private float startX;
    private float endX;

    private float windowTimer = 0.5f;
    public float timer;
    private bool playTimer;
    public bool start;
    public bool end;

    private void Start()
    {
        currentScrean = screans[0];
        transform.position = new Vector3(currentScrean.transform.position.x, currentScrean.transform.position.y,-10f);
    }

    // Update is called once per frame
    void Update()
    {
        if (playTimer)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                playTimer = false;
                timer = windowTimer; 
            }
            return;
        }
 
        if (Input.touchCount > 0)
        {


            Touch touch = Input.GetTouch(0);
            Vector3 pos = touch.position;

          //  Debug.Log(new Vector3(pos.x, pos.y, -10));

            if (touch.phase == TouchPhase.Began)
            {
                startX = Camera.main.ScreenToWorldPoint(new Vector3(pos.x,pos.y, -10f)).x;
                start = true;
     
            }
            if (touch.phase == TouchPhase.Ended) {
                endX = Camera.main.ScreenToWorldPoint(new Vector3(pos.x, pos.y, -10f)).x;
             
                end = true;
                Debug.Log(end);

            }
       //     Debug.Log("Start " + startX + " end " + endX);
            if (start && end)
            {
                changeScrean();
            }
        }
    }

    public void changeScrean() {

        GameObject firstScrean = screans[0];
        GameObject lastScrean = screans[screans.Length-1];
        Debug.Log(startX - endX);

        if (startX - endX > 1f) {
            if (currentWindow == 0)
            {
                transform.position = lastScrean.transform.position;
                transform.position = new Vector3(transform.position.x, transform.position.y, -10);
                currentWindow = screans.Length - 1;
                currentScrean = lastScrean;
            }
            else
            {
                gameObject.transform.position = screans[currentWindow - 1].transform.position;
                currentScrean = screans[currentWindow - 1];
                transform.position = new Vector3(transform.position.x, transform.position.y, -10);
                currentWindow--;
            }

        }
        if (startX - endX < -1f) {
            if (currentWindow == screans.Length-1)
            {
                transform.position = firstScrean.transform.position;
                transform.position = new Vector3(transform.position.x, transform.position.y, -10);
                currentScrean = firstScrean;
                currentWindow = 0;

            }
            else
            {
                gameObject.transform.position = screans[currentWindow+1].transform.position;
                transform.position = new Vector3 (transform.position.x, transform.position.y, -10);
                currentScrean = screans[0];
                currentWindow++;

            }


        }
        start = false;
        end = false;
        playTimer = true;

        
    }


}
