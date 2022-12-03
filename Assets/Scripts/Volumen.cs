using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumen : MonoBehaviour
{
    public Slider slider;
    public float slidervalue;
    public Image imagemute;
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
        AudioListener.volume = slider.value;
        RevisarSiEstoyMute();
    }
    public void ChangeSlider(float valor)
    {
        slidervalue = valor;
        PlayerPrefs.SetFloat("volumenAudio", slidervalue);
        AudioListener.volume = slider.value;
        RevisarSiEstoyMute();
    }
    public void RevisarSiEstoyMute()
    {
        if (slidervalue==0)
        {
            imagemute.enabled = true;
        }
        else
        {
            imagemute.enabled = false;
        }
      
    }
}
