using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour {

    public GameObject StartMenu;
    public GameObject SettingsMenu;
    public GameObject HelpMenu;

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Settings()
    {
        StartMenu.SetActive(false);
        SettingsMenu.SetActive(true);
    }

    public void Help()
    {
        StartMenu.SetActive(false);
        HelpMenu.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit Appication.");
    }

    public void SettingsBackButon()
    {
        StartMenu.SetActive(true);
        SettingsMenu.SetActive(false);
    }

    public void MenuBackButon()
    {
        StartMenu.SetActive(true);
        HelpMenu.SetActive(false);
    }
}
