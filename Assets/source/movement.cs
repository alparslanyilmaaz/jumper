using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class movement : MonoBehaviour
{
    float directionX;

    public Sprite sp;
    public Sprite sp1;
    public Sprite sp2;
    public Sprite sp3;

    Rigidbody2D rb;
    public float movespeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        string a = PlayerPrefs.GetString("spritePlayer");
        if (a.Equals("")) {
            GetComponent<SpriteRenderer>().sprite = sp;
        }
        else if (a.Equals("playerFace"))
        {
            GetComponent<SpriteRenderer>().sprite = sp1;
        }
        else if (a.Equals("playerFace2"))
        {
            GetComponent<SpriteRenderer>().sprite = sp2;
        }
        else if (a.Equals("playerFace3"))
        {
            GetComponent<SpriteRenderer>().sprite = sp3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        directionX = CrossPlatformInputManager.GetAxis("Horizontal");
    }
    void FixedUpdate(){
        rb.velocity = new Vector2(directionX * movespeed * 2, rb.velocity.y);
    }
}