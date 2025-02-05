using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class CameraShake : MonoBehaviour
{    
    float elapsedTime = 0;
    public float duration;

    public float magnitude;

    Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
        
    }    

    public void Shake()
    {
        StartCoroutine(ShakeCR());
    }

    IEnumerator ShakeCR()
    {
        elapsedTime = 0;
        do
        {
            Debug.Log("mover posicion");
            elapsedTime += Time.deltaTime; 
            transform.position = new Vector3(Random.Range(-1, 1) * magnitude, Random.Range(-1, 1) * magnitude, startPos.z);
            yield return new WaitForSeconds(0);
        }while(elapsedTime < duration);

        // reset position
        transform.position = startPos;        
    }
}
