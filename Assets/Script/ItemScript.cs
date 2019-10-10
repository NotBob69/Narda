using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item")]
public class ItemScript : ScriptableObject
{

    public int itemId;
    public Sprite itemSprite;
    public ItemType type;
    public float itemCost;

    public ItemScript(int itemId, ItemType type, float itemCost)
    {
        this.itemId = itemId;
        this.type = type;
       // itemSprite = sprite;
        this.itemCost = itemCost;
    }

    public enum ItemType { junk, loot, food, cleaning };
}
