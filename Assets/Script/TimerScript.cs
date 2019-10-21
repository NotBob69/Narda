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

    //variable to stop timer
    public bool timeEnd;

    //text object variable
    [SerializeField] TextMeshProUGUI countdown;

    public void Start()
    {
        currentTime = startingTime;
    }

    public void Update()
    {
        if (!timeEnd)
        {
            currentTime -= 1 * Time.deltaTime;
            countdown.text = currentTime.ToString();

        }
        if (currentTime <= 0)
        {
            timeEnd = true;
            countdown.text = 0.ToString();
        }
    }
}