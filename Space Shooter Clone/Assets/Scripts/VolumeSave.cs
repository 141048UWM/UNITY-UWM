using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VolumeSave : MonoBehaviour
{
    [SerializeField] private Slider VolumeSlider = null;
    [SerializeField] private Text VolumeText = null;


    private void Start()
    {
        LoadValues();
    }
    public void volumeSlider(float volume)
    {
        VolumeText.text = volume.ToString("0.0");
    }

    public void saveVolume()
    {
        float VolumeVal = VolumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", VolumeVal);
        LoadValues();
    }
    void LoadValues()
    {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        VolumeSlider.value = volumeValue;
        AudioListener.volume = volumeValue;
    }


}
