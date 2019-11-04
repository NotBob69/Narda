using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class User
{
    public int userScore;
    public string userName;
    public string localId;

    public User()
    {
        userName = Register.playerName;
        localId = Register.localId;
    }
}
