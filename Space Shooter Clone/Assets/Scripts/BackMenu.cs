using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackMenu : MonoBehaviour
{
    public void backMenu()
    {
        SceneManager.LoadScene(0);
        AudioListener.pause = false;
        PauseMenu.GameIsPaused = false;
        GoldCount.gold = 0;
        ScoreCount.scoreValue = 0;
    }

}
