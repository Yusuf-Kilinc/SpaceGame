using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TurboMovement : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    bool isPressed = false;
    public float Speed;
    public GameObject Player;
    public GameObject PlayerBasic;
    public GameObject PlayerTurbo;
    public AudioSource ses;
    public AudioClip BasicSound;
    public AudioClip TurboSound;

    public Slider slider;
    public float nitropower;
    void Start()
    {
        ses.clip = BasicSound;
        nitropower = 100;
    }


    void Update()
    {
        slider.value = nitropower;
        if (isPressed)
        {
            if (slider.value > 0)
            {
                PlayerTurbo.SetActive(true);
                PlayerBasic.SetActive(false);
                Player.transform.Translate(0, Speed, 0);
                nitropower -= 25 * Time.deltaTime;
                ses.volume = 0.5f;
                ses.clip = TurboSound;
                ses.Play();
               
            }
        }else if (!isPressed)
        {
            ses.volume = 0.3f;
            ses.clip = BasicSound;
            ses.Play();
            PlayerTurbo.SetActive(false);
            PlayerBasic.SetActive(true);
        }

        if(nitropower >= 100) 
        {
            nitropower = 100;
        }
        if (nitropower <= 0)
        {
            nitropower = 0;
        }


    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}
