using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerScript : MonoBehaviour
{
    //setting the time
    float currentTime = 0f;
    float startingTime = 60f;

    //text object variable
    [SerializeField] TextMeshProUGUI countdown;

    public void Start()
    {
        currentTime = startingTime;
    }

    public void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        print(currentTime);
    }
}
