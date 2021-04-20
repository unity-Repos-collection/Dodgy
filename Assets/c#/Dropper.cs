using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{   
    MeshRenderer renderer;
    Rigidbody rigidbody;
 
    [SerializeField]float dropdelay = 10f;
    // Start is called before the first frame update
    void Start()
    {   
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;

        invisiblemesh();
    }

    // Update is called once per frame
    void Update()
    {
        timer();
    }

    void drop()
    {   
        rigidbody.useGravity = true;               
    }


    void timer()
    {
        if(Time.time >= dropdelay) 
        {
            renderer.enabled = true;
            drop();
        }
    }

    void invisiblemesh()
    {
        renderer.enabled = false;
    }



}



