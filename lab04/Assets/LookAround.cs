using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    // ruch wokół osi Y będzie wykonywany na obiekcie gracza, więc
    // potrzebna nam referencja do niego (konkretnie jego komponentu Transform)
    public Transform player;
    public float min = -90;
    public float max = 90;
    private float rotation;
    private Quaternion origiRotation;
    public float sensitivity = 200f;

    void Start()
    {
        origiRotation = transform.rotation;
        // zablokowanie kursora na środku ekranu, oraz ukrycie kursora
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // pobieramy wartości dla obu osi ruchu myszy
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        //float mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        rotation += Input.GetAxis("Mouse Y") *sensitivity * Time.deltaTime;
        rotation = ClampAngel(rotation, min, max);
        transform.localRotation = origiRotation * Quaternion.AngleAxis(rotation, Vector3.right);
        // wykonujemy rotację wokół osi Y
        player.Rotate(Vector3.up * mouseXMove);

        // a dla osi X obracamy kamerę dla lokalnych koordynatów
        // -mouseYMove aby uniknąć ofektu mouse inverse
        //transform.Rotate(new Vector3(-mouseYMove, 0f, 0f), Space.Self);
       
    }
    public float ClampAngel(float Angle, float min, float max)
    {
        if (Angle < -360.0f)
            Angle += 360.0f;
        if (Angle > 360.0f)
            Angle -= 360.0f;
        return Mathf.Clamp(Angle, min, max);
    }
}
