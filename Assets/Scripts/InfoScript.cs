using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoScript : MonoBehaviour
{

public Dropdown characterDropdown;     
    public Text scrollViewText;           

    
    [TextArea(3, 10)]
    public string[] characterDescriptions;

    void Start()
    {
        characterDropdown.onValueChanged.AddListener(UpdateScrollViewText);
        UpdateScrollViewText(characterDropdown.value); 
    }
    void UpdateScrollViewText(int index)
    {
        if (index >= 0 && index < characterDescriptions.Length)
        {
            scrollViewText.text = characterDescriptions[index];
        }
        else
        {
            scrollViewText.text = "No information available.";
        }
    }
}