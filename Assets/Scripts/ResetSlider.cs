using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetSlider : MonoBehaviour
{
    public void Reset(Slider slider)
    {
        if (slider.CompareTag("Slider Transport (Electrification)")) {
            slider.value = 0;
        }
        if (slider.CompareTag("Slider Transport (Efficiency)")) {
            slider.value = 20;
        }
        if (slider.CompareTag("Slider Energy (Coal)")) {
            slider.value = 90;
        }
        if (slider.CompareTag("Slider Emission (Methane And Others)")) {
            slider.value = 100;
        }
        if (slider.CompareTag("Slider Energy (Renewables)")) {
            slider.value = 40;
        }
        if (slider.CompareTag("Slider Energy (Carbon Price)")) {
            slider.value = 0;
        }
        if (slider.CompareTag("Slider Buildings (Efficiency)")) {
            slider.value = 30;
        }
        if (slider.CompareTag("Slider Growth (Economic)")) {
            slider.value = 50;
        }
        if (slider.CompareTag("Slider Growth (Population)")) {
            slider.value = 40;
        }

        //int halfvalue = (int) slider.maxValue / 2;
        //slider.value = halfvalue;
    }
}
