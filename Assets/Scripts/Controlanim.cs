using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlanim : MonoBehaviour
{
    public Rigidbody Rigid;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("colider"))
        {
            gameObject.SetActive(false);
            Rigid.useGravity = false;
            Rigid.Sleep();
        }
    }
}
