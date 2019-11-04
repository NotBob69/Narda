using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievmentController : MonoBehaviour
{

    public AchievmentList list;
    public AchievmentPopUp popUp;
    public GameObject gameplayManager;
    public bool test;



    private PetStats petStats;


    public void Start()
    {
        gameplayManager = GameObject.Find("Gameplay manager");
        petStats = gameplayManager.GetComponent<PetStats>();
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

        if (petStats.health <= 0)
            CompleteAchievment(list.achievmentList[0]);
    }
    public void Exterminate() {

        if (StatusCheck(1))
            return;

        if (petStats.pestKilled >= 100)
            CompleteAchievment(list.achievmentList[1]);

    }
    public void Metamorphosis() {
        if (StatusCheck(2))
            return;

        if (petStats.haveReachedMax && petStats.haveDied)
            CompleteAchievment(list.achievmentList[2]);
    }




    public void CompleteAchievment(Achievment achievment) {

        achievment.aStatus = true;
        popUp.PlayAnim(achievment);
        achievment.aShown = true;
    }

}
