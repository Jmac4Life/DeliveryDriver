using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool boolhasPackage;

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ouch!");
    }
    
    void OnTriggerEnter2D(Collider2D other) 
    {


        // if (the thing we trigger is the package)
        // The print "package picked up" to the console

        if (other.tag == "Package") 
        {
            Debug.Log("Package picked up");
            boolhasPackage = true;
        }

        if (other.tag == "Customer" && boolhasPackage) 
        {
            Debug.Log("Package Delivered");
            boolhasPackage = false;
        }


    }

}
