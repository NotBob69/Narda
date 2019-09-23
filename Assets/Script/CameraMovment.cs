using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    public GameObject[] windows;
    public float startX;
    public bool start;
    public float endX;
    public bool end;


    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount == 0)
        {
            return;
        }


        Touch touch = Input.touches[1];
        Vector3 pos = touch.position;

        if (touch.phase == TouchPhase.Began)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(pos);
            startX = pos.x;
            start = true;
        }
        if (touch.phase == TouchPhase.Ended)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(pos);
            endX = pos.x;
            end = true;

        }

        if (start && end)
            ChangeScrean();


    }


    public void ChangeScrean() {





    }

}
