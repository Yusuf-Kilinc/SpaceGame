using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainTurboScript : MonoBehaviour
{
    public GameObject MainCharacther;
    public GameObject TurboCharacther;
    public GameObject Player;

    public float Speed;
    public float TurboSpeed;
    public float Blueenergy;

    public AudioSource source;
    public AudioClip NormalSound;
    public AudioClip TurboSound;
    public Slider slider;
    public Image SliderFill;
    public bool ispressed;
    // Start is called before the first frame update
    void Start()
    {
        TurboCharacther.SetActive(false);
      //  source= GetComponent<AudioSource>();
        source.clip = NormalSound;
        Blueenergy = 100;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = Blueenergy;   

        if(ispressed)
        {
            if (Blueenergy > 1) 
            {
                MainCharacther.SetActive(false);
                TurboCharacther.SetActive(true);
                Player.transform.Translate(0, Speed, 0);
                Blueenergy -= 25 * Time.deltaTime;
              //  source.volume = 0.5f;
              //  source.clip = TurboSound;
              //  source.Play();
            }
        } else if (!ispressed)
        {
            TurboCharacther.SetActive(false);
            MainCharacther.SetActive(true);
          //  source.volume = 0.3f;
          //  source.clip = NormalSound;
           // source.Play();
        }


        if (Blueenergy > 70)
        {
            SliderFill.color = Color.green;
        }
        if (Blueenergy < 70 && Blueenergy > 50) 
        {
            SliderFill.color = Color.blue;
        }
        if (Blueenergy < 50 && Blueenergy > 30)
        {
            SliderFill.color = Color.yellow;
        }
        if (Blueenergy < 30)
        {
            SliderFill.color = Color.red;
        }



    }
}
