using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TeleportLVL2INBetween : MonoBehaviour
{
    [SerializeField] GameObject gm;
    [SerializeField] GameObject gm1;
    public bool gm2;
    // Start is called before the first frame update
    void Start()
    {
        gm2 = false;
        gm.SetActive(false);
        gm1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(HP_BOSS_LVL2.hp <= 0)
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
        SceneManager.LoadScene(7);
        PlayerShoot.isFiring = true;
    }
}
