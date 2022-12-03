using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_sup : MonoBehaviour
{
    [SerializeField] private AudioClip[] Audio;
    private AudioSource controlar_audio;

    private void Awake()
    {
        controlar_audio = GetComponent<AudioSource>();
    }
    public void SeleccionAudio(int indice,float volumen)
       
    {
        controlar_audio.PlayOneShot(Audio[indice], volumen);
    }

}
