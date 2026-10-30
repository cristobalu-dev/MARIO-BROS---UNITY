using TMPro;
using UnityEngine;
public class VidasJuego : MonoBehaviour
{
    private ControladorVidas controladorVidas;
    private TextMeshProUGUI vidasJuego;
    void Start()
    {
     vidasJuego = GetComponent<TextMeshProUGUI>(); 
    }
    void Update()
    {
        vidasJuego.text = ControladorVidas.Instance.mostrarVidas.ToString("3");
    }
}
