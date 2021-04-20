using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] float Movespeed = 10f;
    
    void Start()
    {
        PrintInsructions();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }


    //Functions
    void PrintInsructions()
    {
        Debug.Log("How to play Dodgy! \n Use asdw to move, and avoid the obsticles!");
    }

    void Movement()
    {
        // y axis not used  float YAxis = Input.GetAxis("Jump")
        float YAxis = 0f;
        
        //speed of movement 
        
        float XAxis = Input.GetAxis("Horizontal") * Time.deltaTime * Movespeed;
        float ZAxis = Input.GetAxis("Vertical") * Time.deltaTime * Movespeed;
        
        //Move mesh
        transform.Translate(XAxis,YAxis,ZAxis);
    }
}
