using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // so we can switch scenes to the game scene

public class MainMenuScript : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public Text countdownTextField;


    public void playGame()
    {
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
    }
    public void letsgo()
    {

        MainMenu.SetActive(false);
        OptionsMenu.SetActive(false);
    }


    public void options()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }
    public void back()
    {
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
    }

    public void exitGame()
    {
        Application.Quit(); //will quite the game when not run in the Unity editor
    }
}