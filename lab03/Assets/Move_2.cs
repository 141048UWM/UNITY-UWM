using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_2 : MonoBehaviour
{
    public List<Transform> wps = new List<Transform>();
    private Transform targetwps;
    private float mindist = 0.1f;
    private int thelastid;
    public float speed;
    private int tgtwpsind = 0;
    private float rotationspeed = 3f;

    private void Start()
    {
        thelastid = wps.Count - 1;
        targetwps = wps[tgtwpsind];
    }

    void FixedUpdate()
    {

        float mvstep = speed * Time.deltaTime;

        Vector3 dirtotgt = targetwps.position - transform.position;

        float angle = Mathf.Atan2(dirtotgt.y, dirtotgt.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationspeed * Time.deltaTime);
        float distance = Vector3.Distance(transform.position, targetwps.position);
        CheckDistance(distance);
        transform.position = Vector3.MoveTowards(transform.position, targetwps.position, speed);
    }

    void CheckDistance(float curDistance)
    {
        if(curDistance <= mindist)
        {
            tgtwpsind++;
            UpdateTarget();
        }
    }
    void UpdateTarget()
    {
        if(tgtwpsind > thelastid)
        {
            tgtwpsind = 0;
        }
        targetwps = wps[tgtwpsind];
    }
}
