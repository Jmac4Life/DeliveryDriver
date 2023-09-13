using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] float fltDestoryDelay = 0.5f;

    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer> ();
    }

    bool boolHasPackage;

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ouch!");
    }
    
    void OnTriggerEnter2D(Collider2D other) 
    {


        // if (the thing we trigger is the package)
        // The print "package picked up" to the console

        if (other.tag == "Package" && !boolHasPackage) 
        {
            Debug.Log("Package picked up");
            boolHasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, fltDestoryDelay);
        }

        if (other.tag == "Customer" && boolHasPackage) 
        {
            Debug.Log("Package Delivered");
            boolHasPackage = false;
            spriteRenderer.color = noPackageColor;
        }


    }

}
