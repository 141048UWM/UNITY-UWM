using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        AudioListener.pause = false;
    }
    public void ChooseUrSpaceShip()
    {
        SceneManager.LoadScene(1);
    }
    public void Settings()
    {
        SceneManager.LoadScene(2);
    }
    public void HotKeys()
    {
        SceneManager.LoadScene(3);
    }
    public void CloseApp()
    {
        Application.Quit();
    }
}
