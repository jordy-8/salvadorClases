using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject score;

    void Start()
    {
        // desactivar
       //score.gameObject.SetActive(false);

       score.GetComponent<TextMeshProUGUI>().text = "score: 100";
    }

    void Update()
    {
        
    }
}
