using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TurboDown : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public MainTurboScript turboScript;
    public AudioSource ses;
    public AudioClip sound;

    //public Camera MainCam;

    public GameObject backPanel;
    public Image backImage;

    public void OnPointerDown(PointerEventData eventData)
    {
        turboScript.ispressed = true;
        turboScript.Speed = -0.4f;
        ses.clip = sound;
        ses.PlayOneShot(sound);
        backPanel.SetActive(true);
        if (turboScript.Blueenergy > 70)
        {
            backImage.color = Color.green;
        }
        if (turboScript.Blueenergy > 50 && turboScript.Blueenergy < 70)
        {
            backImage.color = Color.blue;
        }
        if (turboScript.Blueenergy < 50 && turboScript.Blueenergy > 30)
        {
            backImage.color = Color.yellow;
        }
        if (turboScript.Blueenergy < 30)
        {
            backImage.color = Color.red;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        turboScript.ispressed = false;
        backPanel.SetActive(false);
    }
}
