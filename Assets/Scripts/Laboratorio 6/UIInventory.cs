using TMPro;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    public InvetoryData inventoryData;
    public TextMeshProUGUI LifeTxt;   
    public TextMeshProUGUI SanityTxt;
    public TextMeshProUGUI StaminaTxt;
    public TextMeshProUGUI NumberItemTxt;

    void Start()
    {
        LifeTxt.text = "Life : " + inventoryData.LifePorcentage;
        SanityTxt.text = "Sanity : " + inventoryData.SanityPorcentage;
        StaminaTxt.text = "Stamina : " + inventoryData.StaminaPorcentage;
        NumberItemTxt.text = "Items : " + inventoryData.NumberOfItems;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
