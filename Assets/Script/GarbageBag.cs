using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageBag : MonoBehaviour
{
    public GameObject garbageBag;

    [SerializeField]
    public Transform[] spawnpoint;
    public Transform currentTrashWaypoint;
    public int spawnpointIndex = 0;
    //hit points
    public int hp;

    public ActionScript touched;

    public ItemScript item;
    public int id;
    public ItemScript.ItemType type;
    public float itemCost;
    // Start is called before the first frame update
    void Start()
    {
       // id = item.itemId;
       // gameObject.GetComponent<SpriteRenderer>().sprite = item.itemSprite;
       // type = item.type;
       // itemCost = item.itemCost;

        Spawn();
        touched = gameObject.GetComponent<ActionScript>();

        hp = Random.Range(2, 40);
    }

    // Update is called once per frame
    void Update()
    {
        if (touched.isTouched)
        {
            Clean();
            touched.isTouched = false;
        }
    }

    void Spawn()
    {
        //Choose random spawnpoint
          int spawn = Random.Range(0, spawnpoint.Length);

          this.transform.position = spawnpoint[spawn].position;

        //current location coordinate
           currentTrashWaypoint = spawnpoint[spawn];


          transform.position = spawnpoint[spawn].transform.position;

      //  int bag = Random.Range(4, 10);

     //   for (int i = 0; i < bag; i++ )
     //   {
     //       Instantiate(garbageBag, spawnpoint[Random.Range(0, spawnpoint.Length)].position, new Quaternion(0,0,0,0));
     //   }
    }

    public void Clean()
    {
        hp--;
        if (hp <= 0)
        {

            Destroy(this.gameObject);
        }
    }

    
}
