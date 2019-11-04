using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User
{
    public string userName;
    public string localId;
    public User()
    {
        userName = Register.playerName;
        localId = Register.localId;
    }
}
