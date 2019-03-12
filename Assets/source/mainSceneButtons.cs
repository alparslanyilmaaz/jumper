using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainSceneButtons : MonoBehaviour
{
    void start()
    {
        Time.timeScale = 1;
    }
    public void playOnClick() {
        SceneManager.LoadScene("gameScene");
    }
    public void options()
    {
        SceneManager.LoadScene("optionScene");
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit ();
#endif
    }

    public void back()
    {
        SceneManager.LoadScene("mainScene");
    }
    public void market()
    {
        SceneManager.LoadScene("marketScene");
    }
    public void restart(){
        SceneManager.LoadScene("gameScene");
    }
}
