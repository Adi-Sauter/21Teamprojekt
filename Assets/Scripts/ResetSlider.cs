using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ZenFulcrum.EmbeddedBrowser;

public class ResetSlider : MonoBehaviour
{

    public void Reset(Slider slider)
    {
        //StartCoroutine(SetSliderToStart());

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
    }

    /*
    public IEnumerator SetSliderToStart() {
        
        this.Proxy.relevantProxyType = MouseClickRobot.PROXY_TYPE.TRANSPORT_ELEC;
        Debug.Log("Reset first Slider");
        yield return new WaitForSeconds(1f);
        this.Proxy.relevantProxyType = MouseClickRobot.PROXY_TYPE.TRANSPORT_EFFIC;
        yield return new WaitForSeconds(1f);
        Debug.Log("Noch einen ");
        this.Proxy.relevantProxyType = MouseClickRobot.PROXY_TYPE.ENERGY_COAL;
        yield return new WaitForSeconds(1f);
        Debug.Log("Und nochmal");
        this.Proxy.relevantProxyType = MouseClickRobot.PROXY_TYPE.LAND_METHANE;
        yield return new WaitForSeconds(1f);
        this.Proxy.relevantProxyType = MouseClickRobot.PROXY_TYPE.ENERGY_RENEWABLES;
        yield return new WaitForSeconds(1f);
        this.Proxy.relevantProxyType = MouseClickRobot.PROXY_TYPE.ENERGY_CARBON;
        yield return new WaitForSeconds(1f);
        this.Proxy.relevantProxyType = MouseClickRobot.PROXY_TYPE.BUILDING_ENERGY;
        yield return new WaitForSeconds(1f);
        this.Proxy.relevantProxyType = MouseClickRobot.PROXY_TYPE.GROWTH_ECONOMIC;
        yield return new WaitForSeconds(1f);
        Debug.Log("Der letzte!");
        this.Proxy.relevantProxyType = MouseClickRobot.PROXY_TYPE.GROWTH_POPULATION;

    }
    */
}
