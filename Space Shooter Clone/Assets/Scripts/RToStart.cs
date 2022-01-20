using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RToStart : MonoBehaviour
{
    public static bool GameIsPaused = true;

    public GameObject pauseR;
    private void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            pauseR.SetActive(false);
        }
    }
    public void Resume()
    {
        pauseR.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

}
