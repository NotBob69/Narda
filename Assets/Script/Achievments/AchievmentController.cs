using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievmentController : MonoBehaviour
{

    public AchievmentList list;
    public AchievmentPopUp popUp;
    public GameObject gameplayManager;
    public bool test;


    public void Start()
    {
        gameplayManager = GameObject.Find("Gameplay manager");
    }


    private void Update()
    {
        if (test)
            CompleteAchievment(list.achievmentList[0]);
        

    }
    public bool StatusCheck(int number) {

        if (list.achievmentList[0].aStatus)
            return true;
        else
            return false;
    }

    public void Dieded() {

        if (StatusCheck(0))
            return;

        if (gameplayManager.GetComponent<PetStats>().health <= 0)
            CompleteAchievment(list.achievmentList[0]);
    }
    public void Exterminate() {

        if (StatusCheck(3))
            return;

        if (gameplayManager.GetComponent<PetStats>().pestKilled >= 100)
            CompleteAchievment(list.achievmentList[3]);

    }




    public void CompleteAchievment(Achievment achievment) {

        achievment.aStatus = true;
        popUp.PlayAnim(achievment);
        achievment.aShown = true;
    }

}
