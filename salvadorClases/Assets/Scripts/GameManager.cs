using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject score;

    public int scoreCounter;

    void Start()
    {              

    }

    void Update()
    {

       //poner scoreCounter en el TMP
       score.GetComponent<TextMeshProUGUI>().text = scoreCounter.ToString();        
    }
}
