using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    bool isleft = false;
    bool isright = false;

    public Rigidbody rb;
    public float speedForce;
    
    
    
    public void clickleft()
    {
        isleft = true;
    }
    public void releaseleft()
    {
        isleft = false;
    }
    public void clickright()
    {
        isright = true;
    }
    public void releaseright() 
    {
        isright = false;
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            

        }
        if (Input.GetButtonDown("Horizontal"))
        {
            rb.AddForce(new Vector3(0, 0, speedForce * Time.deltaTime));
        }
    }

    private void FixedUpdate()
    {
        
        
      if(isleft)
        {
            rb.AddForce(new Vector3(0, 0, -speedForce) * Time.deltaTime);
        }
       
        if (isright)
        {
            rb.AddForce(new Vector3(0, 0,speedForce) * Time.deltaTime);
        }
    }
}
