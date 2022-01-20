using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shop : MonoBehaviour
{
    public Text hape_;
    public Text atk_;
    public static int hape;
    public static int atk;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hape_.text = "Hp+ " + hape.ToString();
        atk_.text = "Attack+ " + atk.ToString();

    }

    public void buyHP()
    {
        if (GoldCount.gold >= 2000)
        {
            hape += +5;
            if(hape >= 20)
            {
                hape = 20;
            }
            Player.hp += 5;
            GoldCount.gold -= 2000;
            if (Player.hp >= 20)
            {
                Player.hp = 20;
                GoldCount.gold += 2000;
            }
            if (Player.hp_stable >= 70)
            {
                Player.hp_stable = 70;
                GoldCount.gold += 2000;
            }
        }

    }
    public void buyAttack()
    {
        if (GoldCount.gold >= 4500)
        {
            PlayerShoot._attack += 1;
            GoldCount.gold -= 4500;
            atk++;
        }
    }
}
