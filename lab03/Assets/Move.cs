using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float distance;
    [SerializeField] float speed;

    public Vector3 start;
    void Start()
    {
        start = transform.position;
    }

    void Update()
    {
        Vector3 f = start;
        f.x += distance * Mathf.Sin(Time.time * speed);
        transform.position = f;

    }

}
