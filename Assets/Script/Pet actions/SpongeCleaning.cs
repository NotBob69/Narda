using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpongeCleaning : MonoBehaviour
{
    private Vector3 mousePosition;
    private GameObject gameplaymanager;


    private void Start()
    {
		
        gameplaymanager = GameObject.Find("Gameplay manager");
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {

            Clean(Input.mousePosition);

        }

        if (gameplaymanager.GetComponent<PetStats>().cleanless >= 100)
        {
            Destroy(this.gameObject);
        }
        



    }


    public void Clean(Vector3 v3)
    {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(v3);
        if (Physics.Raycast(ray, out hit))
        {
			FindObjectOfType<AudioManager>().Play("cleaning_pet");

            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10));
            transform.position = Vector2.Lerp(transform.position, mousePosition, 10);



        }



    }
    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Pet")) {
            gameplaymanager.GetComponent<PetStats>().cleanless += 5;
            gameplaymanager.GetComponent<PetStats>().UpdateStats();

            if (gameObject.GetComponent<PetStats>().health <= 0)
                gameObject.GetComponent<PetStats>().cleaningDead = true;

        }

    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Pet"))
        {
            gameplaymanager.GetComponent<PetStats>().cleanless += 5;
            gameplaymanager.GetComponent<PetStats>().UpdateStats();

        }


    }
}
