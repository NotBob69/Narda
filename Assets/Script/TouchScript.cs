using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScript : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            PCTESTCLICK(Input.mousePosition);

        }

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
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.GetComponent<ActionScript>() != null)
                 hit.collider.gameObject.GetComponent<ActionScript>().isTouched = true;
       
            }
        }



    }
    public void PCTESTCLICK(Vector3 v3)
    {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(v3);
        if (Physics.Raycast(ray, out hit))
        {

            if (hit.collider.gameObject.GetComponent<ActionScript>() != null)
                hit.collider.gameObject.GetComponent<ActionScript>().isTouched = true;

        }
    }



}
