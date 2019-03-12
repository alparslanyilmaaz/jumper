using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class market : MonoBehaviour
{
    public GameObject notEnoughPanel;

    public GameObject equipPanel1;
    public GameObject equipPanel2;
    public GameObject equipPanel3;

    public GameObject boughtPanel;

    public GameObject player;

    public Sprite playerFace;
    public Sprite playerFace2;
    public Sprite playerFace3;

    public GameObject equipedPanel1;
    public GameObject equipedPanel2;
    public GameObject equipedPanel3;
    // Start is called before the first frame update

    void Start()
    {
        Time.timeScale = 1;
        notEnoughPanel.SetActive(false);
        boughtPanel.SetActive(false);

        //equip buttons
        string control1 = PlayerPrefs.GetString("item0");
        if (control1.Equals(""))
        {
            equipPanel1.SetActive(false);
        }
        else
        {
            equipPanel1.SetActive(true);
        }
        string control2 = PlayerPrefs.GetString("item2");
        if (control2.Equals(""))
        {
            equipPanel2.SetActive(false);
        }
        else
        {
            equipPanel2.SetActive(true);
        }
        string control3 = PlayerPrefs.GetString("item3");
        if (control3.Equals(""))
        {
            equipPanel3.SetActive(false);
        }
        else
        {
            equipPanel3.SetActive(true);
        }

        //Equiped Panel

        string spriteWhich = PlayerPrefs.GetString("spritePlayer");

        if (spriteWhich.Equals("playerFace")){
            equipedPanel1.SetActive(true);
        }
        else
        {
            equipedPanel1.SetActive(false);
        }
        if (spriteWhich.Equals("playerFace2"))
        {
            equipedPanel2.SetActive(true);
        }
        else
        {
            equipedPanel2.SetActive(false);
        }
        if (spriteWhich.Equals("playerFace3"))
        {
            equipedPanel3.SetActive(true);
        }
        else
        {
            equipedPanel3.SetActive(false);
        }

    }

    public void BuyItem1(){
        
        int gold = PlayerPrefs.GetInt("score");
        if (gold >= 10){
            gold = gold - 10;
            PlayerPrefs.SetInt("score", gold);
            PlayerPrefs.SetString("item0", "bought");
            boughtPanel.SetActive(true);
        }
        else{
            notEnoughPanel.SetActive(true);
        }
    }
    public void BuyItem2(){
        
        int gold = PlayerPrefs.GetInt("score");
        if (gold >= 20)
        {
            gold = gold - 20;
            PlayerPrefs.SetInt("score", gold);
            PlayerPrefs.SetString("item2", "bought");
            boughtPanel.SetActive(true);
        }
        else
        {
            notEnoughPanel.SetActive(true);
        }
    }
    public void BuyItem3()
    {
        int gold = PlayerPrefs.GetInt("score");
        if (gold >= 30)
        {
            gold = gold - 30;
            PlayerPrefs.SetInt("score", gold);
            PlayerPrefs.SetString("item3", "bought");
            boughtPanel.SetActive(true);
        }
        else
        {
            notEnoughPanel.SetActive(true);
        }
    }
    public void equip1(){
        equipedPanel1.SetActive(true);
        equipedPanel2.SetActive(false);
        equipedPanel3.SetActive(false);
        player.GetComponent<SpriteRenderer>().sprite = playerFace;
        PlayerPrefs.SetString("spritePlayer", "playerFace");
    }
    public void equip2()
    {
        equipedPanel1.SetActive(false);
        equipedPanel2.SetActive(true);
        equipedPanel3.SetActive(false);
        player.GetComponent<SpriteRenderer>().sprite = playerFace2;
        PlayerPrefs.SetString("spritePlayer", "playerFace2");
    }
    public void equip3()
    {
        equipedPanel1.SetActive(false);
        equipedPanel2.SetActive(false);
        equipedPanel3.SetActive(true);
        player.GetComponent<SpriteRenderer>().sprite = playerFace3;
        PlayerPrefs.SetString("spritePlayer", "playerFace3");
    }
}
