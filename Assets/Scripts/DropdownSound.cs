using UnityEngine;
using UnityEngine.UI;

public class DropdownSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] optionSounds;
    public Dropdown dropdown;

    void Start()
    {
        dropdown.onValueChanged.AddListener(PlaySoundForOption);
    }

    void PlaySoundForOption(int index)
    {
        if (index < optionSounds.Length && optionSounds[index] != null)
        {
            audioSource.PlayOneShot(optionSounds[index]);
        }
    }
}