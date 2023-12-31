using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float fltSteerSpeed = 1f;
    [SerializeField] float fltMoveSpeed = 20f;
    [SerializeField] float fltSlowSpeed = 15f;
    [SerializeField] float fltBoostSpeed = 30f;

    // Update is called once per frame
    void Update()
    {
        float fltSteerAmount = UnityEngine.Input.GetAxis("Horizontal") * fltSteerSpeed * Time.deltaTime;
        float fltMoveAmount = UnityEngine.Input.GetAxis("Vertical") * fltMoveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -fltSteerAmount);
        transform.Translate(0, fltMoveAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        fltMoveSpeed = fltSlowSpeed;
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Boost") 
        {
            fltMoveSpeed = fltBoostSpeed;
        }
    }
}
