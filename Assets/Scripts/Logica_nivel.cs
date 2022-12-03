using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logica_nivel : MonoBehaviour
{
    public Jeison reizor;
    public GameObject PanelNext;
    void Start()
    {

        if (reizor.pasNivel == true)
        {
            PanelNext.SetActive(true);

        }
        else
        {
            PanelNext.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
