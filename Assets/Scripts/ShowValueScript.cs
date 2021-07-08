using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ShowValueScript : MonoBehaviour
{
    TextMeshProUGUI valueText;
    // Start is called before the first frame update
    void Start()
    {
        valueText = GetComponent<TextMeshProUGUI>();
    }

    public void textUpdate(float value)
    {
        valueText.text = "Value = " + value;
    }
} 