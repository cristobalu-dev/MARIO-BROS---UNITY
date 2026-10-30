using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TiempoJuego : MonoBehaviour
{
    private float tiempo;
    private Text text_tiempo;


    private void Start()
    {
        text_tiempo = GetComponent<Text>();
    }

    private void Update()
    {
        tiempo += Time.deltaTime;
        text_tiempo.text = tiempo.ToString("0");
    }
}
