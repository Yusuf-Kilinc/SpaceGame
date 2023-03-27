using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Movement : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    bool isPressed = false;
    public float Speed;
    public GameObject Player;

    public GameObject BackPanel;

    void Update()
    {
        if (isPressed)
        {
            Player.transform.Translate(0, Speed, 0);
            BackPanel.SetActive(true);
        } 
        if(!isPressed)
        {
            BackPanel.SetActive(false);
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