using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class playerhealth : MonoBehaviour
{public bool isPlayerDead = false;
    public int health = 1;
    public TMP_Text playerhealthText;
    public static playerhealth instance;
    
    public void takedamage(int damage){
        health -= damage;
        playerhealthText.text= "Health:"+health;
    }
    void Awake(){
        playerhealthText.text= "Health:"+health;
        instance = this;
    }
    void Update (){
        if (health <= 0){
           die();
        }
    } 
    public void die(){isPlayerDead = true;
               gameObject.SetActive(false);}
}
