using UnityEngine;
using UnityEngine.UI;

public class MissionUI : MonoBehaviour
{
    public Text missionText;
    public MissionManager missionManager;

    private void Update()
    {
        UpdateMissionUI();
    }

    private void UpdateMissionUI()
    {
        string missionInfo = "Mission:\n";

        foreach (Mission mission in missionManager.missions)
        {
            string status = mission.IsCompleted ? "Completed" : "Not complete";
            missionInfo += mission.Name + ": " + status + "\n";
        }

        missionText.text = missionInfo;
    }
}


