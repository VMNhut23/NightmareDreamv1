using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Mission", menuName ="Mission")]
public class DataManager : ScriptableObject
{
    public List<MissionData> listData = new List<MissionData>();
}
