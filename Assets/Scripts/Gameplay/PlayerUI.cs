using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI promptText;
    [SerializeField]
    private Slider HealthBar;
    [SerializeField]
    private Slider AbilityPointBar;
    [SerializeField]
    private Slider StaminaBar;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void UpdateResource(float amount, ResourceType resource)
    {
        //Updates Resource Bars based on amount and resource
        switch (resource)
        {
            case ResourceType.Health:
                HealthBar.value = amount; 
                break;
            case ResourceType.AbilityPoints:
                AbilityPointBar.value = amount; 
                break;
            case ResourceType.Stamina:
                StaminaBar.value = amount; 
                break;
        }
    }

    public void UpdateResource(float amount, float max, ResourceType resource)
    {
        switch (resource)
        {
            case ResourceType.Health:
                HealthBar.maxValue = max; 
                break;
            case ResourceType.AbilityPoints:
                AbilityPointBar.maxValue = max; 
                break;
            case ResourceType.Stamina:
                StaminaBar.maxValue = max; 
                break;
        }
        UpdateResource(amount, resource);
    }

    public void UpdatePrompt(string promptMessage)
    {
        promptText.text = promptMessage;
    }
    public enum ResourceType
    {
        Health,
        AbilityPoints,
        Stamina
    }
}
