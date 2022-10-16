using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject inGameUI, pauseUI;

    public  void playGame(){
        SceneManager.LoadScene("Main");
    }
    public  void quitGame(){
        print("apliksi berhasil dikeluarkan");
        Application.Quit();
    }

    public void pauseGame(){

        inGameUI.SetActive(false);
        pauseUI.SetActive(true);
        Time.timeScale = 0;

    }
    public void playGameAgain(){
        pauseUI.SetActive(false);
        inGameUI.SetActive(true);
        Time.timeScale = 1;
    
    }

    public void backToMenu(){
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
}
