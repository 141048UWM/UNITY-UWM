using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoldCount : MonoBehaviour
{
    public static int gold = 0;
    Text gold_;
    // Start is called before the first frame update
    void Start()
    {
        gold_ = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        gold_.text = "Gold: " + gold;
    }
}
