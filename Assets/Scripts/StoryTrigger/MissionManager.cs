using System.Collections.Generic;
using UnityEngine;

public class MissionManager : MonoBehaviour
{
    public List<Mission> missions = new List<Mission>();

    private void Start()
    {
        InitializeMissions();
    }

    private void InitializeMissions()
    {
        Mission mission1 = new Mission("Mission 1", "Mission completed 1");
        Mission mission2 = new Mission("Mission 2", "Mission completed 2");

        missions.Add(mission1);
        missions.Add(mission2);
    }

    public void CompleteMission(string missionName)
    {
        Mission mission = missions.Find(m => m.Name == missionName);
        if (mission != null)
        {
            mission.IsCompleted = true;
            Debug.Log("Mission completed: " + missionName);
        }
    }
}


