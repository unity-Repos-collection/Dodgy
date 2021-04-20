using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinnywinny : MonoBehaviour
{
    //Variables for spin()
    [SerializeField] float Yrotator = 1f;
    [SerializeField] float rotatespeed = 0.1f;
    
    [SerializeField] float movespeed = 0.01f;
    [SerializeField] float XAxis = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        move();
        spin();
    }

    //spin "spinny winny"
    void spin()
    {
        float Xrotator = 0f;
        float Zrotator = 0f;
        transform.Rotate(Xrotator,Yrotator,Zrotator * Time.deltaTime * rotatespeed);
    }

    
    
    
    
    //come back to finish
    void move()
    {
        float YAxis = 0f;
        float ZAxis =0f;
        transform.Translate(XAxis,YAxis,ZAxis * Time.deltaTime * movespeed, Space.World);
    }

}
