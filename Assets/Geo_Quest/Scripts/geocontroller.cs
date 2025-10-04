using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class geocontroller : MonoBehaviour 
{
    string hello = "Hello ";
    string variable1 = "Hello";
    private int var1 = 3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");

        string world = "world";
        Debug.Log(hello + world);


        string variable2 = "World";
        Debug.Log(variable1 + variable2);
        public int speed = 5;
        
        
    }

    // Update is called once per frame
    void Update()
 {
    {
      
        
        Debug.Log(var1++);
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);
        }
        float xInput = Input.GetAxis("Horizontal");
        Debug.Log(xInput);
        rb.velocity = new Vector2 (xInput + speed, rb.velocity.y);

    }
}