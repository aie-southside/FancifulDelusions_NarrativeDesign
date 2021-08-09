using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour

{
    public GameObject journalScreen;
    public GameObject miniMenu;
    public GameObject howToPlay;
    public string mainMenu;
    public GameObject player;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            journalScreen.SetActive(true);
            //Cursor.lockState = CursorLockMode.None;
            //player.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            miniMenu.SetActive(true);
        }
    }

    public void HowToPlayMenu()
    {
        howToPlay.SetActive(true);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}