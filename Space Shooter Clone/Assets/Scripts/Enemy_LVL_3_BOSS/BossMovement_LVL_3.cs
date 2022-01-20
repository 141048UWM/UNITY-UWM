using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement_LVL_3 : MonoBehaviour
{
    [SerializeField] float distance;
    [SerializeField] float speed;
    // Start is called before the first frame update
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(0f, Mathf.Sin(Time.time * speed)) * distance;
    }
}
