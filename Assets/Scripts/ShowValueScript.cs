using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ShowValueScript : MonoBehaviour
{
    TextMeshProUGUI valueText;
    void Start()
    {
        valueText = GetComponent<TextMeshProUGUI>();
    }

    public void textUpdate(float value)
    {
        valueText.text = "Value = " + value;
    }
} 