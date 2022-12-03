using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Agarrar : MonoBehaviour
{
    RaycastHit hit;
    Ray ray;
    Camera cam;
    public bool seleccion = true;
    public GameObject anim;
    Rigidbody animRigid;
    MeshFilter animFilter;
    MeshRenderer animRender;
    public Transform inicioanim;
    public Managernivel manager;
    public Colision coli;
    public Image[] imagenlistaaprovado;
    public Sprite[] spritebuenos;
    public Image[] Renders;
    public GameObject[] product;
    public int suma;
    public Jeison falso;
    public GameObject boton;
    public GameObject boton_no;
    public Repetirnivel pasar;
    public Objetos obj;
    public List<Sprite> proim;
    
    void Start()
    {
        manager = GetComponent<Managernivel>();
        cam = Camera.main;
        animRigid = anim.GetComponent<Rigidbody>();
        animFilter = anim.GetComponent<MeshFilter>();
        animRender = anim.GetComponent<MeshRenderer>();

    }

   
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && seleccion == true)
        {
            ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out hit) && hit.transform.GetComponent<Objetos>()!=null)
            {
                anim.SetActive(true);
                anim.transform.position = inicioanim.position;
                anim.transform.localScale = hit.transform.localScale;
                animRigid.useGravity = true;
                animFilter.mesh = hit.transform.GetComponent<MeshFilter>().sharedMesh;
                animRender.materials = hit.transform.GetComponent<MeshRenderer>().materials;
                if(coli.list.Contains(hit.transform.GetComponent<Objetos>().nombre) == false)
                {
                    coli.list.Add(hit.transform.GetComponent<Objetos>().nombre );
                    if (hit.transform.GetComponent<Objetos>().etiketas.valor == manager.valor && hit.transform.GetComponent<Objetos>().etiketas.nomcolor == manager.color&& hit.transform.GetComponent<Objetos>().etiketas.nomEtiqueta == manager.nomEtiqueta)
                    {
                        imagenlistaaprovado[suma].sprite = spritebuenos[0];
                        manager.puntosbuenos++;
                        coli.list2.Add(" Aprovado");
                    }
                    else
                    {
                        imagenlistaaprovado[suma].sprite = spritebuenos[1];
                        manager.puntosmalos++;
                        coli.list2.Add(" Rechazado");
                    }
                    suma++;
                   
                    {
                        proim.Add(hit.transform.GetComponent<Objetos>().Imag);
                    }
                }
                
                
               /* if (hit.transform.GetComponent<Objetos>().etiketas.valor == manager.valor && hit.transform.GetComponent<Objetos>().etiketas.nomcolor == manager.color)
                {
                    manager.puntosbuenos++;
                }
                else
                {
                    manager.puntosmalos++;
                }*/
               

            }
        }

        if (manager.puntosbuenos > 0 && manager.puntosmalos == 0 && manager.puntosbuenos >= falso.nvl)
        {
            falso.pasNivel = true;
            boton.SetActive(true);
        }
        else 
        {
            falso.pasNivel = false;
           boton.SetActive(false);
            
        }
   
       
    
        /*
         if(manager.puntosbuenos==jeison.punetos buenos maximos alcanzables ){
        pasampos el nievel 
        activar boton siguiente nivel
        }
        else{
        no pasamos nivel
        desactivando el boton siguiente nivel 
        }
         */
    }
}
