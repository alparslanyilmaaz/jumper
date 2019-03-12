using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falseAlarm : MonoBehaviour
{
    public GameObject panel;

    void start()
    {
        panel.SetActive(false);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }
}
