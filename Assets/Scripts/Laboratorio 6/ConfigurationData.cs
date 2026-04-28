using UnityEngine;

[CreateAssetMenu(fileName = "ConfigurationData", menuName = "Scriptable Objects/ConfigurationData")]
public class ConfigurationData : ScriptableObject
{
    public string Resolution;
    public string fpsLimit;
    public string Vsync;
    public string Graphics;
}
