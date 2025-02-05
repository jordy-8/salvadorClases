using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTest : MonoBehaviour
{
    public Animator animator;

    public void Play()
    {
        StartCoroutine(PlayCR());
    }

    IEnumerator PlayCR()
    {
        Debug.Log("play the game");
        
        // primero hacer fade
        animator.SetTrigger("FadeOutTrigger");
        
        // esperar 1 segundo
        yield return new WaitForSeconds(1);
        
        // cambiar de escena
        SceneManager.LoadScene("Gameplay");        
    }

    public void Exit()
    {
        Debug.Log("exit");
        Application.Quit();
    }
}
