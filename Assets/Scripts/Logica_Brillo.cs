using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logica_Brillo : MonoBehaviour
{
    public Slider slider;
    public float SliderValue;
    public Image panelBrillo;
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("brillo", 0f);
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.b, slider.value);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChageSlider(float valor)
    {
        SliderValue = valor;
        PlayerPrefs.SetFloat("brillo", SliderValue);
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, slider.value);
    }
}
