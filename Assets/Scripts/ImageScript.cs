using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject LeatherChest;
    public GameObject LeatherLeg;
    public GameObject LeatherBoots;
    public GameObject LeatherHelmet;
    public GameObject DimondChest;
    public GameObject DimondLeg;
    public GameObject DimondBoots;
    public GameObject DimondHelmet;
    public GameObject IronChest;
    public GameObject IronLeg;
    public GameObject IronBoots;
    public GameObject IronHelmet;
    public GameObject NeatheriteChest;
    public GameObject NeatherBoots;
    public GameObject NeatheriteHelmet;
    public GameObject imageField;
    public Sprite[] soriteArray;
    public GameObject scaleSlider;
    public GameObject rotationSlider;
    public GameObject widthSlider;
    public GameObject heightSlider;

    public void ChangeWidth()
    {
        float currentWidth = widthSlider.GetComponent<Slider>().value;
        Vector3 currentScale = imageField.transform.localScale;
        imageField.transform.localScale = new Vector3(currentWidth, currentScale.y, currentScale.z);
    }

    public void ChangeHeight()
    {
        float currentHeight = heightSlider.GetComponent<Slider>().value;
        Vector3 currentScale = imageField.transform.localScale;
        imageField.transform.localScale = new Vector3(currentScale.x, currentHeight, currentScale.z);
    }

    public void ChangeScale()
    {
        float currentScale = scaleSlider.GetComponent<Slider>().value;
        imageField.transform.localScale =
            new Vector2(1F * currentScale, 1F * currentScale);
    }

    public void ChangeRotation()
    {
        float currentRotation =
            rotationSlider.GetComponent<Slider>().value;
        imageField.transform.localRotation =
            Quaternion.Euler(0, 0, currentRotation * 360);
    }

    public void Dropdown(int index)
    {
        if (index == 0)
            imageField.GetComponent<Image>().sprite = soriteArray[0];
        else if (index == 1)
            imageField.GetComponent<Image>().sprite = soriteArray[1];
    }

    public void ToggleLeatherChest(bool value)
    {
        LeatherChest.SetActive(value);
    }

    public void ToggleLeatherLeg(bool value)
    {
        LeatherLeg.SetActive(value);
    }

    public void ToggleLeatherBoots(bool value)
    {
        LeatherBoots.SetActive(value);
    }

    public void ToggleLeatherHelmet(bool value)
    {
        LeatherHelmet.SetActive(value);
    }

    public void ToggleDimondChest(bool value)
    {
        DimondChest.SetActive(value);
    }

    public void ToggleDimondLeg(bool value)
    {
        DimondLeg.SetActive(value);
    }

    public void ToggleDimondBoots(bool value)
    {
        DimondBoots.SetActive(value);
    }

    public void ToggleDimondHelmet(bool value)
    {
        DimondHelmet.SetActive(value);
    }

    public void ToggleIronChest(bool value)
    {
        IronChest.SetActive(value);
    }

    public void ToggleIronLeg(bool value)
    {
        IronLeg.SetActive(value);
    }

    public void ToggleIronBoots(bool value)
    {
        IronBoots.SetActive(value);
    }

    public void ToggleIronHelmet(bool value)
    {
        IronHelmet.SetActive(value);
    }

   
    public void ToggleNeatheriteChest(bool value)
    {
        NeatheriteChest.SetActive(value);
    }

    public void ToggleNeatherBoots(bool value)
    {
        NeatherBoots.SetActive(value);
    }

    public void ToggleNeatheriteHelmet(bool value)
    {
        NeatheriteHelmet.SetActive(value);
    }
}