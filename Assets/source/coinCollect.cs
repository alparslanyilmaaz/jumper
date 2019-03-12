using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class coinCollect : MonoBehaviour
{
    public GameObject gm;
    public Text score;

    private int count;

    void Start()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            count = PlayerPrefs.GetInt("score");
            count += 1;
            Destroy(gm);
            PlayerPrefs.SetInt("score", count);
            SetCountText();
        }
    }
    void SetCountText()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();
    }
}
