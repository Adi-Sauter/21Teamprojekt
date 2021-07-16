using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZenFulcrum.EmbeddedBrowser;

public class ExtractImage : MonoBehaviour
{
    public Browser browser;

    public Browser DisplayLeft;

    public Browser DisplayRight;

    public Browser DisplayCenter;

    public PointerUIBase Proxy;

    void Start() {
        StartCoroutine(this.GetTheRightGraph());
    }
    
    public IEnumerator GetTheRightGraph() {
        
        yield return new WaitForSeconds(10f);
        this.Proxy.relevantProxyType = MouseClickRobot.PROXY_TYPE.INITIAL;
        Debug.Log("Get The Right Graph Now!!");
        yield return new WaitForSeconds(2f);
        this.Proxy.relevantProxyType = MouseClickRobot.PROXY_TYPE.LeftGraph1;
        yield return new WaitForSeconds(2f);
        Debug.Log("Noch einen ");
        this.Proxy.relevantProxyType = MouseClickRobot.PROXY_TYPE.LeftGraph2;
        yield return new WaitForSeconds(2f);
        Debug.Log("Und nochmal");
        this.Proxy.relevantProxyType = MouseClickRobot.PROXY_TYPE.LeftGraph3;
        yield return new WaitForSeconds(2f);
        this.Proxy.relevantProxyType = MouseClickRobot.PROXY_TYPE.RightGraph1;
        yield return new WaitForSeconds(2f);
        this.Proxy.relevantProxyType = MouseClickRobot.PROXY_TYPE.RightGraph2;
        yield return new WaitForSeconds(2f);
        Debug.Log("Der letzte!");
        this.Proxy.relevantProxyType = MouseClickRobot.PROXY_TYPE.RightGraph3;

    }
    
    public IEnumerator fetchTemperaturePrediction()
    {
        var promise = this.browser.EvalJS("document.getElementsByClassName(\"primary-temp-value\")[0].innerHTML");
        // old version:
        //var promise = this.browser.EvalJS("document.getElementsByClassName(\"primary-temp-value svelte-1xplu3t\")[0].innerHTML");
        yield return promise.ToWaitFor();
        Debug.Log("promised value: " + promise.Value);
    }
    

    public IEnumerator fetchRightGraph(int index)
    {
        var promise = this.browser.EvalJS("document.getElementsByClassName(\"chartjs-render-monitor\")[" + index + "].toDataURL(\"img/png\")");
        yield return promise.ToWaitFor();
        Debug.Log("promised value: " + promise.Value);
        this.DisplayRight.EvalJS("document.getElementById(\"image-container\").src = '" + promise.Value + "';");
        this.DisplayRight.EvalJS("document.getElementById(\"image-container\").width = '" + 500 + "';");
        this.DisplayRight.EvalJS("document.getElementById(\"image-container\").height = '" + 500 + "';");
    }

    public IEnumerator fetchLeftGraph(int index)
    {
        var promise = this.browser.EvalJS("document.getElementsByClassName(\"chartjs-render-monitor\")[" + index + "].toDataURL(\"img/png\")");
        yield return promise.ToWaitFor();
        Debug.Log("promised value: " + promise.Value);
        this.DisplayLeft.EvalJS("document.getElementById(\"image-container\").src = '" + promise.Value + "';");
        this.DisplayLeft.EvalJS("document.getElementById(\"image-container\").width = '" + 500 + "';");
        this.DisplayLeft.EvalJS("document.getElementById(\"image-container\").height = '" + 500 + "';");
    }

}
