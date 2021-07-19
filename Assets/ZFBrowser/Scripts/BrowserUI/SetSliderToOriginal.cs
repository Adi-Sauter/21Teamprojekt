using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZenFulcrum.EmbeddedBrowser;

public class SetSliderToOriginal : MonoBehaviour
{

    public PointerUIBase Proxy;

    // Start is called before the first frame update
    void Test()
    {
        StartCoroutine(this.ResetSlider());
    }

    public IEnumerator ResetSlider() {
        
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


}
