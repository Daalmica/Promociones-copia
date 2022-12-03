using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambiarnivel : MonoBehaviour
{
    public int nomEscena;
    public Jeison cul;

    public void iniciar()
    {
        cul.lista.Add(nomEscena.ToString());
        SceneManager.LoadScene(nomEscena);
    }
   
}
