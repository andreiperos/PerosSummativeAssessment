using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {        
        rb = GetComponent<Rigidbody>();
    }

    [Range(1, 980)]
    public float jumpVelocity;

    void Update(){
        if(Input.GetButtonDown("Jump")){
            //GetComponent<Rigidbody>().velocity = Vector2.up * jumpVelocity;            
            rb.AddForce(Vector3.up * 2200);
        }
    }
}
