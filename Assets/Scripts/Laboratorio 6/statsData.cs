using UnityEngine;

[CreateAssetMenu(fileName = "StatsData", menuName = "Scriptable Objects/StatsData")]
public class StatsData : ScriptableObject
{
    public string GameProgress;
    public string Deaths;
    public string EnemyKilled;
    public string AchievementProgress;
    public string Money;
    public string SpentMoney;
}
