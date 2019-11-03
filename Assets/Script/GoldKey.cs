using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldKey : MonoBehaviour
{

    private bool isUsed;

   public void Use()
    {

    }

    public void IsUsed()
    {
        GameObject go = GameObject.FindGameObjectWithTag("GoldKey");
        Destroy(go.gameObject);

    }


}
