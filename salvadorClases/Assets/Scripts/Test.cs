using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{    
    void Start()
    {
        StartCoroutine(Saludo());
    }

    IEnumerator Saludo()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("hola");
    }
}
