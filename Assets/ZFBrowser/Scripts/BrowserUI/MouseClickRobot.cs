using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZenFulcrum.EmbeddedBrowser;

public class MouseClickRobot : MonoBehaviour
{
    public enum PROXY_TYPE
    {
        NONE,
        TEST,
        INITIAL,
        TRANSPORT_ELEC,
        TRANSPORT_EFFIC,
        ENERGY_COAL,
        LAND_METHANE,
        ENERGY_RENEWABLES,
        ENERGY_CARBON,
        BUILDING_ENERGY,
        GROWTH_ECONOMIC,
        GROWTH_POPULATION
    }

    public PROXY_TYPE proxyType;

    public float MinX = -1.0f;

    public float MaxX = -1.0f;

    private float initialX;

    void Start()
    {
        this.initialX = this.transform.localPosition.x;
        SliderEventSystem.aBrowserSliderEvent += this.setPercentageNew;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.D))
        {
            if (this.MaxX != -1.0f && this.MinX != -1.0f)
            {
                this.transform.localPosition += new Vector3((this.MaxX - this.MinX) / 100.0f, 0f, 0f);
                if (this.transform.localPosition.x > this.MaxX)
                {
                    this.transform.localPosition = new Vector3(this.MaxX, this.transform.localPosition.y, this.transform.localPosition.z);
                }
            }
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            if (this.MaxX != -1.0f && this.MinX != -1.0f)
            {
                this.transform.localPosition += new Vector3(-(this.MaxX - this.MinX) / 100.0f, 0f, 0f);
                if (this.transform.localPosition.x < this.MinX)
                {
                    this.transform.localPosition = new Vector3(this.MinX, this.transform.localPosition.y, this.transform.localPosition.z);
                }
            }
        }

        /*
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            this.setPercentage(Random.value);
        }
        */
    }

    public void setPercentage(float percentage)
    {
        if (this.MaxX != -1.0f && this.MinX != -1.0f)
        {
            this.transform.localPosition = new Vector3(this.MinX + (this.MaxX - this.MinX) * (percentage / 100) , this.transform.localPosition.y, this.transform.localPosition.z);
            if (this.transform.localPosition.x < this.MinX)
            {
                this.transform.localPosition = new Vector3(this.MinX, this.transform.localPosition.y, this.transform.localPosition.z);
            }
            if (this.transform.localPosition.x > this.MaxX)
            {
                this.transform.localPosition = new Vector3(this.MaxX, this.transform.localPosition.y, this.transform.localPosition.z);
            }
        }
    }

    public void setPercentageNew(float percentage, MouseClickRobot.PROXY_TYPE type) 
    {
        if(this.proxyType == type)
        {
            this.setPercentage(percentage);
        }
    }
}
