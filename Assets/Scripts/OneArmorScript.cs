using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OneArmorScript : MonoBehaviour
{
    public enum ArmorType { Helmet, Chestpiece, Leggings, Boots }

    [System.Serializable]
    public class ArmorToggle
    {
        public ArmorType type;
        public Toggle toggle;
    }

    public List<ArmorToggle> armorToggles = new List<ArmorToggle>();

    void Start()
    {
        foreach (ArmorToggle armorToggle in armorToggles)
        {
            armorToggle.toggle.onValueChanged.AddListener((isOn) => OnToggleChanged(armorToggle, isOn));
        }
    }

    void OnToggleChanged(ArmorToggle changedToggle, bool isOn)
    {
        if (!isOn) return;

        foreach (ArmorToggle armorToggle in armorToggles)
        {
            if (armorToggle != changedToggle && armorToggle.type == changedToggle.type)
            {
                armorToggle.toggle.isOn = false;
            }
        }
    }
}