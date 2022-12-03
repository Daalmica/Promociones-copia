using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Colision : MonoBehaviour
{
    public GameObject panel;
    public List<string> list,list2;
    public TextMeshProUGUI[]textos;
    public Sprite [] renders;
    public Agarrar agarro;
    public Managernivel mana;
    public Jeison jik;
    public GoogleSheetsApi Goo;
    public GameObject seguir;
    public GameObject etuqueta;

    public void Reconteo()
    {
        for (int i = 0; i < list.Count; i++)
        {
            textos[i].text = list[i] ;
            agarro.imagenlistaaprovado[i].gameObject.SetActive(true);
            agarro.product[i].SetActive(true);
            agarro.product[i].GetComponent<Image>().sprite = agarro.proim[i];
        }
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("final"))
        {
            jik.lista.Add(mana.tiempo_2.ToString());
            float p = mana.tiempo_2 + mana.tiempo_1;
            jik.lista.Add(p.ToString());
            panel.SetActive(true);
            seguir.SetActive(false);
            etuqueta.SetActive(false);
            Reconteo();
            jik.lista.Add(mana.puntosbuenos.ToString());
            jik.lista.Add(mana.puntosmalos.ToString());
            Goo.getDataInRange = "A2";
            Goo.CargarDatosNuevosJugadores();
            Goo.ActualizarDatosDeLineaDeCarga();
        }

    }

}
