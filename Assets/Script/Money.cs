using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{

    private float money;


    public void AddMoney(float ammount) {
        money += ammount;

        
    }
    public void TakeMoney(float ammount){
        money -= ammount;

        }

    public float GetMoney() {
        return money;

    }


}
