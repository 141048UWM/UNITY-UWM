using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TeleportLvl1_Inbetween : MonoBehaviour
{
    [SerializeField] GameObject gm;
    [SerializeField] GameObject gm1;
    public bool gm2 = false;
    // Start is called before the first frame update
    void Start()
    {
        gm.SetActive(false);
        gm1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(HPBoss_Lvl_1.hp <= 0)
        {
            gm.SetActive(true);
            gm2 = true;
            if(gm2 == true)
            {
                Time.timeScale = 0f;
                gm1.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    gm2 = false;
                    inTOTP();
                }
            }

        }
    }
    public void inTOTP()
    {
        SceneManager.LoadScene(5);
        PlayerShoot.isFiring = true;
    }
}
