using UnityEngine;

/// <summary>
/// This class allows us to load a scene automatically, in a certain programmed moment.
/// </summary>
public class menu : MonoBehaviour
{

    public GameObject MainMenu;
    public GameObject OptionsMenu;


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