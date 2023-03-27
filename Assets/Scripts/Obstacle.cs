using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject Player;
    public GameObject Death;
    float gnmslskgs;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        else if (collision.tag == "Player")
        {
            Instantiate(Death, Player.transform);
            Time.timeScale = 0;
           Destroy(Player.gameObject);
        }
    }


    void yoketme()
    {
        Destroy(Player.gameObject);
    }


}
