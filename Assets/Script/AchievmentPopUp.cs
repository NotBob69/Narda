using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AchievmentPopUp : MonoBehaviour
{

    public Animator anim;
    public Image image;
    public TextMeshProUGUI aNameText;
    public TextMeshProUGUI aDescription;


    public void PlayAnim(Achievment achievment)
    {
        image.sprite = achievment.achievmentSprite;
        aNameText.text = achievment.id;
        aDescription.text = achievment.description;

        anim.SetTrigger("Apper");


    }




}
