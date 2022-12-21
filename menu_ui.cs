using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class menu_ui : MonoBehaviour
{
    public AudioSource buttonSound;
    public AudioClip buttonClick;

    public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
   
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ClickSound()
    {
        buttonSound.PlayOneShot (buttonClick);
    }
}
