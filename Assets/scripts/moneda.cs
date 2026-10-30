using UnityEngine;

public class moneda : MonoBehaviour
{
    
    [SerializeField] private AudioClip colectar1;
    [SerializeField] private float cantidadPuntos;
    [SerializeField] private GameObject efecto;
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if(collision.tag == "mario")
        {
            ControladorPuntos.Instance.SumarPuntos(cantidadPuntos);
            
            gameObject.SetActive(false);
            ControladorSonido.Instance.EjecutarSonido(colectar1);
            
        }
    }
}
