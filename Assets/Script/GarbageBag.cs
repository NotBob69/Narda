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
    private PetStats petstats;
    // Start is called before the first frame update
    void Start()
    {
        touched = gameObject.GetComponent<ActionScript>();
        petstats = GameObject.Find("Gameplay manager").GetComponent<PetStats>();
        hp = Random.Range(2, 10);
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


    public void Clean()
    {
        hp--;
        if (hp <= 0)
        {
            petstats.GiveCleanless(5);
            Destroy(this.gameObject);
        }
    }

    
}
