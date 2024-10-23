using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject waypoint1;
    public GameObject waypoint2;

    //Transform target;
    Vector3 target;

    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        target = waypoint1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        //this.GetComponent<Transform>().position += new Vector3(0, 1, 0);        

        //transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);        

        // si ya llegó al waypoint1
        if(transform.position == target)
        {
            //cambiar de target / waypoint
            target = waypoint2.transform.position;
        }

        // si ya llegó al waypoint2
        if(transform.position == target)
        {
            //cambiar de target / waypoint1
            target = waypoint1.transform.position;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("choco con " + col.gameObject.name);
        if(col.gameObject.name == "personaje")
        {
            //hacer daño al jugador
            col.GetComponent<Player>().TakeDamage(1);
        }
    }
}
