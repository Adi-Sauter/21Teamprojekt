using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayCastScript : MonoBehaviour
{
    private GameObject hitObject;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                if(hit.transform)
                {
                    //PrintName(hit.transform.gameObject);
                    this.hitObject = hit.transform.gameObject;
                    CurrentClickedGameObject(hit.transform.gameObject);
                }   
            }
        }
        if(Input.GetMouseButtonUp(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                // perform a specified action on the object that was hit last
                CurrentReleasedObject(hitObject);

                //different method, where it´s checked first wether hit.transform exists (hit.transform != null)
                // if(hit.transform)
                // {
                //      if(hit.transform.gameObject.tag != hitObject.tag)
                //     {
                //         Debug.Log("hit.transform != hitObject");
                //         PrintTag(hit.transform.gameObject.tag, "new hitObject");
                //         PrintTag(hitObject.tag, "hitobject");
                //         CurrentReleasedObject(hitObject);
                //     } else
                //     {
                //         Debug.Log("hit.transform == hitObject");
                //         PrintTag(hit.transform.gameObject.tag, "new hitObject");
                //         PrintTag(hitObject.tag, "hitobject");
                //         CurrentReleasedObject(hit.transform.gameObject);
                //     }
                // }
            }
        }
    }
    private void CurrentClickedGameObject(GameObject go)
    {
        if(go.tag == "Handle")
        {
            go.GetComponent<Image>().color = Color.white;
            go.GetComponentInChildren<MeshRenderer>().material.color = Color.white;
        }
        if(go.tag == "Button")
        {
            go.GetComponent<Image>().color = Color.black;
            go.GetComponentInChildren<MeshRenderer>().material.color = Color.black;
        }
    }
    private void CurrentReleasedObject(GameObject go)
    {
        if(go.tag == "Handle")
        {
        go.GetComponent<Image>().color = Color.red;
        go.GetComponentInChildren<MeshRenderer>().material.color = Color.red; 
        }
        if(go.tag == "Button")
        {
            go.GetComponent<Image>().color = Color.blue;
            go.GetComponentInChildren<MeshRenderer>().material.color = Color.blue;
        }
    }
    private void PrintName(GameObject go)
    {
        Debug.Log(go.name);
    }
    private void PrintTag(string tag, string name)
    {
        Debug.Log("Name des " + name + ": " + tag);
    }
}
