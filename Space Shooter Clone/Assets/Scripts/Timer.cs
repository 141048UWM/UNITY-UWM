using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public Text nameText;
    public Text nameText2;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        nameText.GetComponent<Shield>().shieldTime.ToString();
        nameText2.GetComponent<Shield>().nextShieldTimer.ToString();
    }
}
