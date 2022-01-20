using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    private float x_sc;
    public float Sc_speed = 0.15f;
    private MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scroll();
    }
    private void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
    }
    void scroll()
    {
        x_sc = Time.time * Sc_speed;

        Vector2 offset = new Vector2(x_sc, 0f);
        mesh.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
