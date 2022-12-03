using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Repetirnivel : MonoBehaviour
{
    public GameObject []objetosjuego;
    public Managernivel nivel;
    public int puntosbuenos, puntosmalos;
    public Jeison reizor;
    public GameObject PanelNext;
    public GameObject PanelBack;
    public GameObject seguir;
   void Start()
    {
        
        
    }
    
    void Update()
    {

       
       if (nivel.puntosbuenos==reizor.nvl&& reizor.pasNivel == true)
        {
            PanelNext.SetActive(true);
           PanelBack.SetActive(false);
            
        }
        else if (nivel.puntosmalos == reizor.nvl && reizor.pasNivel == false)
        {

            PanelBack.SetActive(true);
            PanelNext.SetActive(false);
        }
      

     
    }
   
	
}
