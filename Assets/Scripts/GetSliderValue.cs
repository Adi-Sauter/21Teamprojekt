using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetSliderValue : MonoBehaviour
{
    public int getvalue(Slider slider)
    {
        return (int) slider.value;
    }
}
