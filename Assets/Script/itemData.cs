using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemData : MonoBehaviour
{

    public ItemScript item;


    public int id;
    public ItemScript.ItemType type;
    public float itemCost;



    // Start is called before the first frame update
    void Start()
    {
        id = item.itemId;
        gameObject.GetComponent<SpriteRenderer>().sprite = item.itemSprite;
        type = item.type;
        itemCost = item.itemCost;

    }
}
