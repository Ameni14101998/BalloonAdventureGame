using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
public class Ballon : MonoBehaviour
{
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //retourne type 
        rb.isKinematic = true;
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    /*
    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z + transform.position.z);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition); //prend position de la souris
        transform.position = objPosition;
        rb.isKinematic = true;
    }
    private void OnMouseUp()
    {
        rb.isKinematic = false;
    }
    */
     void OnMouseDown()
    {
        if (Boutton.ballbool == 1)
        {
            rb.isKinematic = false;
            Boutton.ballbool = 0;
        }
    }
 }

