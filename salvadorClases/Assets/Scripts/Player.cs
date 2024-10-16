using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{    
    float speed = 50;

    void Start()
    {

    }

    void Update()
    {
        Debug.Log("speed= " + speed);
        MoveByRigidbody();        
    }

    void MoveByRigidbody()
    {
        // que se mueva a la derecha cuando aprieto la tecla d
        if(Input.GetKey("d"))
        {                    
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(speed * Time.deltaTime, 0);            
        }
        // que se mueva a la izquierda cuando aprieto la tecla a
        if(Input.GetKey("a"))
        {            
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-speed * Time.deltaTime, 0);            
        }
        // que se deje de mover cuando suelto la tecla a
        if(Input.GetKeyUp("d") || Input.GetKeyUp("a"))
        //if((Input.GetKeyUp("d") || Input.GetKeyUp("a")) && !(Input.GetKey("d") || Input.GetKey("a")))
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        }
    }

    void MoveByTransform()
    {
        //this.GetComponent<Transform>().position = new Vector3(2,0,0);
        // que se mueva a la derecha cuando aprieto la tecla d
        if(Input.GetKey("d"))
        {
            this.GetComponent<Transform>().position += new Vector3(speed * Time.deltaTime,0,0);
        }

        // que se mueva a la izquierda cuando aprieto la tecla a
         if(Input.GetKey("a"))
        {
            this.GetComponent<Transform>().position += new Vector3(-speed * Time.deltaTime,0,0);
        }        
    }

    public void ChangeSpeed(float _amount)
    {
        Debug.Log("change speed");
        speed += _amount;
    }

    

}
