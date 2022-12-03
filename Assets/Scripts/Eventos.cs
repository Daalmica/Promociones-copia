using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Eventos : MonoBehaviour
{



    [Header("Data")]
    public InputField RecopiladoNombre;
    public InputField recopiladorCedula;
    
    public List<string> recom;
    public List<string> lag;
    public GameObject nom;
    public GameObject next;
    public Jeison jey;
    public GoogleSheetsApi google;
    public Dropdown drop;
    void Start()
    {
        jey.lista.Clear();
        jey.nvl = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void NuevoJugador()
    {
        if (string.IsNullOrWhiteSpace(RecopiladoNombre.text)==false&& string.IsNullOrWhiteSpace(recopiladorCedula.text) == false)
        {
            string ha = RecopiladoNombre.text + " " + recopiladorCedula.text;
            jey.lista.Add(ha);
           // jey.lista.Add(recopiladorCedula.text);
             
            nom.SetActive(true);

        }
        
    }
   public void OldPlayer()
    {
        lag.Clear();
        google.ReadDataGlobal();
        google.ReadData();
        Filtro();
    }
    public void Filtro()
    {
        for (int i = 0; i < lag.Count; i++)
        {
            for (int j = 0; j < lag.Count; j++)
            {
                if (i!=j)
                {
                    if (lag[i]==lag[j])
                    {
                        lag.RemoveAt(j);
                        Filtro();
                        return;
                    }
                }
            }
            drop.ClearOptions();
            drop.AddOptions(lag);
        }

    }
    public void SelecOldPlayer()
    {
        int L = drop.value;
        jey.lista.Add(lag[L]);
    }
}
