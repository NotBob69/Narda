using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldKey : MonoBehaviour
{

    private Vector3 mousePosition;

   public void Use()
    {

    }

    public void IsUsed()
    {

        Destroy(this.gameObject);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {

            MoveKey(Input.mousePosition);

        }
    }


    public void MoveKey(Vector3 v3)
    {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(v3);
        if (Physics.Raycast(ray, out hit))
        {

            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10));
            transform.position = Vector2.Lerp(transform.position, mousePosition, 10);



        }


        Destroy(this.gameObject);

    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Chest"))
        {
            IsUsed();


        }

    }



}
