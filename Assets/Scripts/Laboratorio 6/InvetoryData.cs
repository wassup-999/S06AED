using UnityEngine;

[CreateAssetMenu(fileName = "InvetoryData", menuName = "Scriptable Objects/InvetoryData")]
public class InvetoryData : ScriptableObject
{
    public string LifePorcentage;
    public string SanityPorcentage;
    public string StaminaPorcentage;
    public string NumberOfItems;
}
