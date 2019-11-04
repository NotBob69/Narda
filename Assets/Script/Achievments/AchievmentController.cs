using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievmentController : MonoBehaviour
{

    public AchievmentList list;
    public AchievmentPopUp popUp;

    private PetStats petStats;


    public void Start()
    {
        petStats = GameObject.Find("Gameplay manager").GetComponent<PetStats>();
    }


    private void Update()
    {
        /*
        Dieded();
        Exterminate();
        Metamorphosis();
        CleaningYourMistakes();
        Tapper();
        ItsSomthing();
        Debug.Log("hi");
        //6 achievments
        */

        if (petStats.health <= 0)
            CompleteAchievment(list.achievmentList[0]);

        if (petStats.pestKilled >= 100)
            CompleteAchievment(list.achievmentList[1]);

        if (petStats.haveReachedMax && petStats.haveDied)
            CompleteAchievment(list.achievmentList[2]);

        if (petStats.cleaningDead)
            CompleteAchievment(list.achievmentList[3]);

        if (petStats.petTapping >= 100)
            CompleteAchievment(list.achievmentList[4]);

        if (petStats.currentLevel >= 3)
            CompleteAchievment(list.achievmentList[5]);

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
    public void CleaningYourMistakes() {

        if (StatusCheck(3))
            return;

        if (petStats.cleaningDead)
            CompleteAchievment(list.achievmentList[3]);

    }
    public void Tapper()
    {
        if (StatusCheck(4))
            return;

        if (petStats.petTapping >= 100)
            CompleteAchievment(list.achievmentList[4]);


    }
    public void ItsSomthing() {
        if (StatusCheck(5))
            return;

        if (petStats.currentLevel >= 3)
            CompleteAchievment(list.achievmentList[5]);



    }




    public void CompleteAchievment(Achievment achievment) {

        achievment.aStatus = true;

        if (!achievment.aShown)
           popUp.PlayAnim(achievment);

        achievment.aShown = true;
    }

}
