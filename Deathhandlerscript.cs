using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Deathhandlerscript : MonoBehaviour
{
 public zombiehealth enemy;
    public playerhealth player ;

    float timer = 5f;
    public TMP_Text text;
    private void Update()
    {
        Debug.Log("ZombieStatus: "+enemy.isZombieDead);
        Debug.Log("PlayerStatus: "+player.isPlayerDead);
        if (enemy.isZombieDead == true || player.isPlayerDead == true)
        {
            if (enemy.isZombieDead == true ){
                text.text="YOU WON!";
            } else if (player.isPlayerDead == true ){
                text.text="YOU LOST!";
            }
            text.enabled=true;

            timer -= Time.deltaTime;
            Debug.Log(timer);
            if(timer < 0)
            {
                Debug.Log("Loading");
                SceneManager.LoadScene(0);
            }
        }
    }
}