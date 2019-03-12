using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMenu : MonoBehaviour
{
    public GameObject pause;
    public GameObject play;
    public GameObject pausePanel;
    public GameObject GameoverPanel;

    void Start()
    {
        Time.timeScale = 1;
        GameoverPanel.SetActive(false);
        play.SetActive(false);
        pause.SetActive(true);
        pausePanel.SetActive(false);
    }
    public void stopGame(){
        Time.timeScale = 0;
        play.SetActive(true);
        pause.SetActive(false);
        pausePanel.SetActive(true);
    }
    public void contuine(){
        Time.timeScale = 1;
        play.SetActive(false);
        pause.SetActive(true);
        pausePanel.SetActive(false);
    }
}
