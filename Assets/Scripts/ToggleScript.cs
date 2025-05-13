using UnityEngine;
using UnityEngine.UI;
public class ToggleScript : MonoBehaviour
{
    public Toggle visibilityToggle;
    private SpriteRenderer spriteRenderer; 

    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();

        if (visibilityToggle != null)
        {
            visibilityToggle.onValueChanged.AddListener(OnToggleChanged);
        }
    }

    void OnToggleChanged(bool isOn)
    {

        spriteRenderer.enabled = !isOn;
    }
}