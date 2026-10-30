using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D cuerpo;
    float velocidad;
    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
        velocidad = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
