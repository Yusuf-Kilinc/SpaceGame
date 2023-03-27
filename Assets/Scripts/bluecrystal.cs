using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluecrystal : MonoBehaviour
{
    MainTurboScript Mta;

    private void Start()
    {
        Mta = GameObject.FindGameObjectWithTag("Dumbledoor").GetComponent<MainTurboScript>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Mta.Blueenergy += 20;
            Destroy(this.gameObject);
        }
    }
}
