using UnityEngine;

public class ControladorVidas : MonoBehaviour
{
    public static ControladorVidas Instance;
    [SerializeField] private int cantidadVidas;
    public int mostrarVidas;

    private void Awake()
    {
        if(ControladorVidas.Instance == null)
        {
            ControladorVidas.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SumarVida(int vida)
    {
        cantidadVidas += vida;
        mostrarVidas = cantidadVidas;
    }

    public void RestarVida(int vida)
    {
        cantidadVidas -= vida;
        mostrarVidas = cantidadVidas;
    }
}
