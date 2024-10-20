using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    int min = -4;

    int max = 4;

    void Start()
    {
        
    }

    void Update()
    {        
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
       Debug.Log("choco con " + other.gameObject.name);
       
       // destruir
       //Destroy(this.gameObject);

       // desactivar
       this.gameObject.SetActive(false);

       // cambiar de posicion aleatoriamente       
        this.GetComponent<Transform>().position = new Vector2(Random.Range(min, max+1),0);

        //activar
        this.gameObject.SetActive(true);

        // speed-up
        //other.GetComponent<Player>().speed += 0.1f;
        other.GetComponent<Player>().ChangeSpeed(1f);


        // sumar 1 a los items agarrados                
        FindObjectOfType<GameManager>().scoreCounter += 1;
    }

    void MoveByTransform()
    {

    }
}
