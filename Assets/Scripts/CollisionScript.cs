using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionScript : MonoBehaviour
{
    public GameObject targetinSim;
    public GameObject targetinMus;

    public GameObject FadeScreen;

    public GameObject BlackScreenCanvas;
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Teleportation(other));
        
        //Debug.Log("Collision with " + other.gameObject.name);
        // if(other.gameObject.CompareTag("toSimulator"))
        // {
        //     //Debug.Log("if-case: Collision with " + other.gameObject.name);
        //     FadingOut();
        //     StartCoroutine(Wait());
        //     this.transform.localPosition = new Vector3(targetinSim.transform.position.x, this.transform.position.y, targetinSim.transform.position.z);
        // } else if(other.gameObject.CompareTag("toMuseum"))
        // {
        //     //Debug.Log("elseif-case: Collision with " + other.gameObject.name);
        //     FadingOut();
        //     StartCoroutine(Wait());
        //     this.transform.localPosition = new Vector3(targetinMus.transform.position.x, this.transform.position.y, targetinMus.transform.position.z);
        // }
    }
     public void FadingOut()
    {
        FadeScreen.GetComponent<Animation>().Play("BlackFade");
    }



    IEnumerator Teleportation(Collider other) 
    {
        if(other.gameObject.CompareTag("toSimulator"))
        {
            BlackScreenCanvas.SetActive(true);
            //Debug.Log("if-case: Collision with " + other.gameObject.name);
            FadingOut();
            yield return new WaitForSeconds(0.5f);
            this.transform.localPosition = new Vector3(targetinSim.transform.position.x, this.transform.position.y, targetinSim.transform.position.z);
            BlackScreenCanvas.SetActive(false);

        } else if(other.gameObject.CompareTag("toMuseum"))
        {
            BlackScreenCanvas.SetActive(true);
            //Debug.Log("elseif-case: Collision with " + other.gameObject.name);
            FadingOut();
            yield return new WaitForSeconds(0.5f);
            this.transform.localPosition = new Vector3(targetinMus.transform.position.x, this.transform.position.y, targetinMus.transform.position.z);
            BlackScreenCanvas.SetActive(false);
        }
        //Debug.Log("Wating");
        //yield return new WaitForSeconds(2);
    }
}
