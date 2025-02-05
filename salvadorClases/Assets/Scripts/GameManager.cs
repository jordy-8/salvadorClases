using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject score;

    public TextMeshProUGUI score1;
    public TextMeshProUGUI score2;

    public int scoreCounter = 0; // local multiplayer co-op

    public int scoreCounter1 = 0;
    public int scoreCounter2 = 0;

    bool isPaused = false;

    public GameObject pauseSubmenu;

    public GameObject winScreen;

    public GameObject loseScreen;

    int scoreToWin = 5;

    int deathPlayers = 0;

    void Start()
    {
        pauseSubmenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            Pause();
        }

        //UpdateScore(); // LMCOOP

        UpdateScore1(); // LMC
        UpdateScore2(); // LMC

        //CheckIfWin(); // LMCOOP
        CheckIfWin();   //LMC

    }

    void UpdateScore()
    {
        //poner scoreCounter en el TMP
        score.GetComponent<TextMeshProUGUI>().text = scoreCounter.ToString();
    }

    void UpdateScore1()
    {
        //poner scoreCounter en el TMP
        score1.text = scoreCounter1.ToString();
    }

    void CheckIfWin()
    {
        if (scoreCounter >= scoreToWin || scoreCounter1 >= scoreToWin || scoreCounter2 >= scoreToWin)
        {
            Debug.Log("win");

            if (scoreCounter1 >= scoreToWin)
            {
                Debug.Log("player 1 won");
            }

            if (scoreCounter2 >= scoreToWin)
            {
                Debug.Log("player 2 won");
            }
            Win();
        }
    }

    void UpdateScore2()
    {
        //poner scoreCounter en el TMP
        score2.text = scoreCounter2.ToString();
    }

    void Win()
    {
        StartCoroutine(WinCR());
    }

    IEnumerator WinCR()
    {
        winScreen.SetActive(true);
        yield return new WaitForSeconds(1);

        //SceneManager.LoadScene("Level2");
        SceneManager.LoadScene("Level1");
    }

    public void CheckIfGameOver()
    {
        // revisar si hay 1 jugador muerto, el juego continua
        // pero si hay 2 jugadores muertos, el juego termina
        deathPlayers += 1;
        if (deathPlayers == 2)
        {
            Lose();
        }
    }

    public void Lose()
    {
        StartCoroutine(LoseCR());
    }

    IEnumerator LoseCR()
    {
        loseScreen.SetActive(true);
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("MainMenu");
    }

    void Pause()
    {
        isPaused = !isPaused;
        if (isPaused == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        pauseSubmenu.SetActive(isPaused);
    }

    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
        //SceneManager.LoadScene("Level1");
    }
}
