using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderEventSystem : MonoBehaviour
{
    public delegate void BrowserSliderEvent(float percentage, MouseClickRobot.PROXY_TYPE type);
    public static BrowserSliderEvent aBrowserSliderEvent;
}
