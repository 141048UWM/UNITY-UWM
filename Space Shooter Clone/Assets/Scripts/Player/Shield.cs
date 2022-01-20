using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shield : MonoBehaviour
{
    private Player pl;
    public GameObject shield;
    private bool activeShield;
    public float shieldTime = 2;
    private bool nextShield = true;
    public double nextShieldTimer = 12;
    public Text nameText;
    public Text nameText2;
    public Text ShieldRdy;
    public Text LoadingSh;

    //
    void Start()
    {
        activeShield = false;
        shield.SetActive(false);
    }

    void Update()
    {
        //tarcza zostanie aktywowana jesli wcisniety bedzie przycisk tab
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (!activeShield)
            {
                shield.SetActive(true);
                activeShield = true;
                //nextShield = false;
            }
        }
        //jesli tarcza aktywowana leci jej czas w dól
        if (activeShield)
        {
            ShieldRdy.text = "In Use";
            shieldTime -= Time.deltaTime;
            if (shieldTime < 0)
            {
                shieldTime = 0;
                nameText.text = shieldTime.ToString();
                ShieldRdy.text = "Used";
            }
            
            nameText.text = shieldTime.ToString();
            if (shieldTime > 0)
            {
                //zeby tarcza dzialala zmienilem warstwe Player w warstwe enemy bullet, zeby byc niewidocznym dla pociskow przeciwnika
                gameObject.layer = 12;
                activeShield = true;
            }
            else
            {
                //powrot do warstwy Player
                gameObject.layer = 10;
                activeShield = false;
            }
        }
        //jesli czas aktywowanej tarczy sie skonczy to odpali sie timer ktory bedzie obliczal jej czas do ponownego aktywowania
        if (shieldTime <= 0)
        {
            ShieldRdy.text = "Loading...";
            nextShieldTimer -= Time.deltaTime;
            if (nextShieldTimer < 0)
            {
                nextShieldTimer = 0;
                nameText2.text = nextShieldTimer.ToString();
                

            }
            LoadingSh.text = "Loading...";
            nameText2.text = nextShieldTimer.ToString();
            shield.SetActive(false);
        }
        //jesli tarcza nieaktywoana i czas ladujacy tarcze sie obliczy to bedzie mozna ja aktywowac i timer do nastepnego shielda bedzie zresetowany do 10
        if (!activeShield)
        {
            if(nextShieldTimer <= 0)
            {
                LoadingSh.text = "Loaded";
                nextShield = true;
                nextShieldTimer = 6;
            }
            else
            {
                nextShield = false;
            }
        }
        //jesli nastepna tarcza bedzie true to jej czas bedzie zresetowany do stanu poczatkowego, w tym przypadku 2 sekundy
        if (nextShield)
        {
            ShieldRdy.text = "Ready To Use";
            shieldTime = 4;
        }
    }
    public bool _activeShield
    {
        get
        {
            return activeShield;
        }
        set
        {
            activeShield = value;
        }
    }
}
