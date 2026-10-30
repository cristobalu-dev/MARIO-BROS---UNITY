using UnityEngine;

public class ControladorPuntos : MonoBehaviour
{
    public static ControladorPuntos Instance;
    [SerializeField] private float cantidadPuntos;
    public float mostrarPuntos;

    private void Awake()
    {
        if(ControladorPuntos.Instance == null)
        {
            ControladorPuntos.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SumarPuntos(float puntos)
    {
        cantidadPuntos += puntos;
        mostrarPuntos = cantidadPuntos;
    }
    
    void Start()
    {
        cantidadPuntos = 0;
    }

    void Update()
    {
        CienPuntos();
    }

    public void CienPuntos()
    {
        if(cantidadPuntos >= 5)
        {
            ControladorVidas.Instance.SumarVida(1);
            cantidadPuntos = 0;
        }
    }
    
}
