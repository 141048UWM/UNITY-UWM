using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject gm;
    // Start is called before the first frame update
    void Start()
    {
        gm.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.health <= 0)
        {
            Time.timeScale = 0f;
            gm.SetActive(true);
        }
    }
}
