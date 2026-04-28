using TMPro;
using UnityEngine;

public class UIConfiguration : MonoBehaviour
{
    public ConfigurationData configurationData;
    public TextMeshProUGUI resolution;
    public TextMeshProUGUI fpslimit;
    public TextMeshProUGUI vsync;
    public TextMeshProUGUI graphics;
    void Start()
    {
        resolution.text = "Resolution : " + configurationData.Resolution;
        fpslimit.text = "FPS :" + configurationData.fpsLimit;
        vsync.text = "Vsync :" +configurationData.Vsync;
        graphics.text = "Graphics :" +configurationData.Graphics;
    }

    
    void Update()
    {
        
    }
}
