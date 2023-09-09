using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float fltSteerSpeed = 1f;
    [SerializeField] float fltMoveSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()    
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float fltSteerAmount = UnityEngine.Input.GetAxis("Horizontal") * fltSteerSpeed;
        float fltMoveAmount = UnityEngine.Input.GetAxis("Vertical") * fltMoveSpeed;
        transform.Rotate(0, 0, -fltSteerAmount);
        transform.Translate(0, fltMoveAmount, 0);
    }
}
