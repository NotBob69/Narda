using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Malee;


[CreateAssetMenu(fileName ="Achievments")]
public class AchievmentList : ScriptableObject
{
    [Reorderable]
    public AchievmentsArray achievmentList;

    [System.Serializable]
    public class AchievmentsArray : ReorderableArray<Achievment> { }
}
