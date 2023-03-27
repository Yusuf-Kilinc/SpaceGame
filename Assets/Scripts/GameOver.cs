using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverPanel;
    public GameObject DurdurButton;

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            GameOverPanel.SetActive(true);
            DurdurButton.SetActive(false);
        }
        else
        {
            DurdurButton.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
    }

    public void Home()
    {
        SceneManager.LoadScene("Home 1");
    }

}
