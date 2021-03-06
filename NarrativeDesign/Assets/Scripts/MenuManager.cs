using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour

{
    public GameObject journalScreen;
    public GameObject miniMenu;
    public GameObject howToPlay;
    public string mainMenu, startScene, getHelp, escape, getAdopted;
    public GameObject player;

    //public Texture2D cursorTexture;
    //public CursorMode cursorMode = CursorMode.Auto;
    //public Vector2 hotSpot = Vector2.zero;

    //void SetCursorTexture()
    //{
    //    Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    //}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            journalScreen.SetActive(true);
            Debug.Log("E pressed");
            //Cursor.lockState = CursorLockMode.None;
            //Cursor.visible = true;
            //SetCursorTexture();
 
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            miniMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            //SetCursorTexture();
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
    public void GetHelp()
    {
        SceneManager.LoadScene(getHelp);
    } 
    public void Escape()
    {
        SceneManager.LoadScene(escape);
    } 
    public void GetAdopted()
    {
        SceneManager.LoadScene(getAdopted);
    }
    public void StartScene()
    {
        SceneManager.LoadScene(startScene);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ResumeGame()
    {
        miniMenu.SetActive(false);
        //how to lock cursor after this
    }

}