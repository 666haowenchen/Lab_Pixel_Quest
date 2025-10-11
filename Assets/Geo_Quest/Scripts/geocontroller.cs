using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
public class geocontroller : MonoBehaviour 
{
    string hello = "Hello ";
    string variable1 = "Hello";
    private int var1 = 3;
    public int speed = 5;
    Rigidbody2D body2D;
    public string nextLevel = "level 2";
    public string deathScene = "death scene";
    public int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        body2D =  GetComponent<Rigidbody2D>();
        Debug.Log("Hello World");

        string world = "world";
        Debug.Log(hello + world);


        string variable2 = "World";
        Debug.Log(variable1 + variable2);
        
   
    }

    // Update is called once per frame
    void Update(){


        /*
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
        */

            float xInput = Input.GetAxis("Horizontal");
            Debug.Log(xInput);
            body2D.velocity = new Vector2(xInput * speed, body2D.velocity.y);
       

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       switch (collision.tag)
        {
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
            case "Death":
                {
                    health -= 10;
                    if (health <= 0)
                    {
                        string thisLevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(deathScene);
                    }
                    break;
                }
        }
    }

}

