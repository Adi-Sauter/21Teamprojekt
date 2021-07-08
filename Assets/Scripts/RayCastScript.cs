using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayCastScript : MonoBehaviour
{
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
                if(hit.transform)
                {
                    CurrentReleasesObject(hit.transform.gameObject);
                }   
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
            go.GetComponent<Image>().color = Color.white;
            go.GetComponentInChildren<MeshRenderer>().material.color = Color.white;
        }
    }
    private void CurrentReleasesObject(GameObject go)
    {
        if(go.tag == "Handle")
        {
        go.GetComponent<Image>().color = Color.red;
        go.GetComponentInChildren<MeshRenderer>().material.color = Color.red; 
        }
        if(go.tag == "Button")
        {
            go.GetComponent<Image>().color = Color.red;
            go.GetComponentInChildren<MeshRenderer>().material.color = Color.red;
        }
    }
    private void PrintName(GameObject go)
    {
        Debug.Log(go.name);
    }
}
