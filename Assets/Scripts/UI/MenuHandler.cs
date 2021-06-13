﻿using UnityEngine;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour
{
    private bool mainMenu;
    public PauseManager pauseManager;
    public MainMenuHandler trans;
    public GameObject credits;

    void Start() {
        mainMenu = (trans != null);
    }

    public void Play()
    {
        if(mainMenu) trans.StartTransition();
        else pauseManager.TogglePause();
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Credits()
    {
        credits.gameObject.SetActive(true);
    }

    public void CloseCredits()
    {
        credits.gameObject.SetActive(false);
    }
}
