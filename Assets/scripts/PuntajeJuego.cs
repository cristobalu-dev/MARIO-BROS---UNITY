using TMPro;
using UnityEngine;
public class PuntajeJuego : MonoBehaviour
{
    private ControladorPuntos controladorPuntos;
    private TextMeshProUGUI puntajeJuego;
    void Start()
    {
     puntajeJuego = GetComponent<TextMeshProUGUI>();   
    }
    void Update()
    {
        puntajeJuego.text = ControladorPuntos.Instance.mostrarPuntos.ToString("0");
    }
}
