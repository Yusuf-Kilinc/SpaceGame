using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonControl : MonoBehaviour
{

    public GameObject MainMenu;
    public GameObject LevellerMenu;
    public GameObject[] SpaceShips;


    // Start is called before the first frame update
    void Start()
    {
        MainMenu.SetActive(true);
        SpaceShips[0].SetActive(true);
        LevellerMenu.SetActive(false);
    }

    public void MainMenuToLevelMenu()
    {
        LevellerMenu.SetActive(true);
        SpaceShips[0].SetActive(false);
        SpaceShips[1].SetActive(true);
        MainMenu.SetActive(false);
    }
    public void LevelMEnuBackToMainMenu()
    {
        MainMenu.SetActive(true);
        SpaceShips[1].SetActive(false);
        SpaceShips[0].SetActive(true);
        LevellerMenu.SetActive(false);
    }

    public void StandartGame()
    {
        SceneManager.LoadScene("AnaGame");
        Time.timeScale = 1.0f;
    }

    public void OneGame()
    {
        SceneManager.LoadScene("GamePlay 1");
        Time.timeScale = 1.0f;
    }

    public void TwoGame()
    {
        SceneManager.LoadScene("GamePlay 2");
        Time.timeScale = 1.0f;
    }
    public void ThreeGame()
    {
        SceneManager.LoadScene("GamePlay 3");
        Time.timeScale = 1.0f;
    }
    public void FourGame()
    {
        SceneManager.LoadScene("GamePlay 4");
        Time.timeScale = 1.0f;
    }
    public void FiveGame()
    {
        SceneManager.LoadScene("GamePlay 5");
        Time.timeScale = 1.0f;
    }
    public void SixGame()
    {
        SceneManager.LoadScene("GamePlay 6");
        Time.timeScale = 1.0f;
    }

    public void ExploreDeepSpaceGames()
    {
        SceneManager.LoadScene("DegiskenArkaplan");
        Time.timeScale = 1.0f;
    }

}
