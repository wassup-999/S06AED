using TMPro;
using UnityEngine;

public class UIStats : MonoBehaviour
{
    public StatsData Stats;
    public TextMeshProUGUI GameProgress;
    public TextMeshProUGUI Deaths;
    public TextMeshProUGUI EnemyKilled;
    public TextMeshProUGUI AchievementProgress;
    public TextMeshProUGUI Money;
    public TextMeshProUGUI SpentMoney;
    void Start()
    {
        GameProgress.text ="Game Progress : " + Stats.GameProgress;
        Deaths.text = "Number of Deaths : " + Stats.Deaths;
        EnemyKilled.text = "Number of Enemy killed : " + Stats.EnemyKilled;
        AchievementProgress.text = "Achievements Progress : " + Stats.AchievementProgress;
        Money.text = "Current Money :" + Stats.Money;
        SpentMoney.text = "Total Spent Money :" + Stats.SpentMoney;
    }

    
    void Update()
    {
        
    }
}
