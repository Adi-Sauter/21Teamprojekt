using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PointerClick : MonoBehaviour
{
    public Slider slider;

    void OnEnable()
    {
    //Subscribe to the Slider Click event
    slider.onValueChanged.AddListener(delegate { sliderCallBack(slider.value); });
    }

    //Will be called when Slider changes
    void sliderCallBack(float value)
    {
    //Debug.Log("Slider Changed: " + value);
    //slider.GetComponentInChildren<Image>().color = Color.cyan;
    slider.GetComponentInChildren<MeshRenderer>().material.color = Color.yellow;  
    }  
    void OnDisable()
    {
    //Un-Subscribe To Slider Event
    slider.onValueChanged.RemoveListener(delegate { sliderCallBack(slider.value); });
    }




    // public void OnBeginDrag(PointerEventData eventData)
    // {
    //     Debug.Log("Drag Begin");
    // }

    // public void OnDrag(PointerEventData eventData)
    // {
    //     Debug.Log("Dragging");
    // }

    // public void OnEndDrag(PointerEventData eventData)
    // {
    //     Debug.Log("Drag Ended");
    // }

    // public void OnPointerClick(PointerEventData eventData)
    // {
    //     Debug.Log("Clicked: " + eventData.pointerCurrentRaycast.gameObject.name);
    // }

    // public void OnPointerDown(PointerEventData eventData)
    // {
    //     Debug.Log("Mouse Down: " + eventData.pointerCurrentRaycast.gameObject.name);
    // }

    // public void OnPointerEnter(PointerEventData eventData)
    // {
    //     Debug.Log("Mouse Enter");
    // }

    // public void OnPointerExit(PointerEventData eventData)
    // {
    //     Debug.Log("Mouse Exit");
    // }

    // public void OnPointerUp(PointerEventData eventData)
    // {
    //     Debug.Log("Mouse Up");
    // }

    

    // public void OnPointerDown(PointerEventData eventData)
    // {
    //     Debug.Log("Click");
    //     //this.GetComponent<Image>().color = Color.cyan;
    //     //this.GetComponentInChildren<MeshRenderer>().material.color = Color.yellow;
    // }

}
