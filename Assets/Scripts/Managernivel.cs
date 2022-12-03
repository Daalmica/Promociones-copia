using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Managernivel : MonoBehaviour
{
    public int[] precio;
    public int valor;
    public Sprite[] etiquetas;
    public string[] colores;
    public string color;
    public TextMeshProUGUI texto,texto2,texto3;
    public Image imagen,imagen2;
    public Color []col;
    public float tiempo_1;
    public int puntosbuenos, puntosmalos;
    public bool incioJ;
    public Jeison jun;
    public float tiempo_2;
    public List<string> re;
    public int A;
    public int col1;
    public string nomEtiqueta;
    public string[] ArrayEtiquetas;
    public Etiketas[] etec;
    public int afec;
    public GameObject modifEti;
    private void Awake()
    {

         A = Random.Range(0, colores.Length);
        col1 = Random.Range(0, etiquetas.Length);
        nomEtiqueta = ArrayEtiquetas[col1];
        imagen.sprite = etiquetas[col1];
        imagen2.sprite = etiquetas[col1];
        valor = precio[Random.Range(0, precio.Length)];
        color = colores[A];
        imagen.color = col[A];
        texto2.text = valor.ToString();
        imagen2.color = col[A];
        texto3.text = valor.ToString();
        
        texto3.text = "$" + valor.ToString() + ".000";
        texto2.text = "$" + valor.ToString() + ".000";
        texto.text = "Busca los productos que tengan un precio de " + "$" + valor.ToString() + ".000" + " ,una etiqueta de color " + color + " y una forma " + nomEtiqueta;
        afec = Random.Range(0, etec.Length);
       

        
    }
    private void Start()
    {
        Invoke("cambios", 0.2f);
    }
    void cambios()
    {
        if (etec[afec].valor != valor)
        {
            etec[afec].valor = valor;
            etec[afec].texto.text = "$" + valor.ToString() + ".000";
           
        }
        if ( etec[afec].nomcolor != color )
        {
           
            etec[afec].nomcolor = color;
            etec[afec].cubo.GetComponent<MeshRenderer>().material.color =col[A];

        }
        if ( etec[afec].nomEtiqueta != nomEtiqueta)
        {
         
            etec[afec].nomEtiqueta = nomEtiqueta;
            etec[afec].gameObject.GetComponent<MeshFilter>().mesh = etec[afec].mesh[col1];
            
        }
     
        
        modifEti = etec[afec].gameObject;
        CalcularPuntos();
    }
    public void CalcularPuntos()
    {
        for (int i = 0; i < etec.Length; i++)
        {
            etec[i].balidar();
        }
    }
    void Update()
    {
        if (!incioJ)
        {
            tiempo_1 += Time.deltaTime;
        }
        else
        {
            tiempo_2 += Time.deltaTime;
        }
      
    }
    public void iniciarJuego()
    {
        incioJ = !incioJ;
        jun.lista.Add(tiempo_1.ToString());
       
       
    }
    public void ReiniciarCarga()
    {
        re.Add(jun.lista[0]);
        re.Add(jun.lista[1]);
        jun.lista.Clear();
        jun.lista = re;
        jun.nvl = 0;
      
    }
    public void ReinicioTotal()
    {
        jun.lista.Clear();
        jun.nvl = 0;
        jun.pasNivel = true;
    }

}
