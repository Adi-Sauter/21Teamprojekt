using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetTemperatur : MonoBehaviour
{
    
    TextMeshProUGUI Temp_value;

    // Start is called before the first frame update
    void Start()
    {
        SliderEventSystem.aTemperatureEvent += this.showTemperature;
        Temp_value = GetComponent<TextMeshProUGUI>();
        //TempText = "+ 3,6°C";
    }

    private void showTemperature(string text)
    {
        this.Temp_value.text = " " + text;
    }
    
}
