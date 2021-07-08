using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZenFulcrum.EmbeddedBrowser;

public class ExtractImage : MonoBehaviour
{
    public Browser browser;

    public Browser DisplayLeft;

    public Browser DisplayRight;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.T))
        {
            StartCoroutine(this.fetchTemperaturePrediction());
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            StartCoroutine(this.fetchRightGraph(1));
        }
        else if (Input.GetKeyUp(KeyCode.L))
        {
            StartCoroutine(this.fetchLeftGraph(0));
        }
    }

    private IEnumerator fetchTemperaturePrediction()
    {
        var promise = this.browser.EvalJS("document.getElementsByClassName(\"primary-temp-value svelte-1o6bcxn\")[0].innerHTML");
        yield return promise.ToWaitFor();
        Debug.Log("promised value: " + promise.Value);
    }

    private IEnumerator fetchRightGraph(int index)
    {
        var promise = this.browser.EvalJS("document.getElementsByClassName(\"chartjs-render-monitor\")[" + index + "].toDataURL(\"img/png\")");
        yield return promise.ToWaitFor();
        Debug.Log("promised value: " + promise.Value);
        this.DisplayRight.EvalJS("document.getElementById(\"image-container\").src = '" + promise.Value + "';");
        this.DisplayRight.EvalJS("document.getElementById(\"image-container\").width = '" + 500 + "';");
        this.DisplayRight.EvalJS("document.getElementById(\"image-container\").height = '" + 500 + "';");
    }

    private IEnumerator fetchLeftGraph(int index)
    {
        var promise = this.browser.EvalJS("document.getElementsByClassName(\"chartjs-render-monitor\")[" + index + "].toDataURL(\"img/png\")");
        yield return promise.ToWaitFor();
        Debug.Log("promised value: " + promise.Value);
        this.DisplayLeft.EvalJS("document.getElementById(\"image-container\").src = '" + promise.Value + "';");
        this.DisplayLeft.EvalJS("document.getElementById(\"image-container\").width = '" + 500 + "';");
        this.DisplayLeft.EvalJS("document.getElementById(\"image-container\").height = '" + 500 + "';");
    }

}
