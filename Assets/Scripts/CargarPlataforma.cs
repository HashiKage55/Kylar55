using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargarPlataforma : ControladorBasico
{

    public GameObject elementoInicial;

    public Transform puntoInicial;

    public GameObject elementoActual;

    public List<GameObject> mapa;
    // Use this for initialization
    void Start()
    {
        base.Start();
        mapa = new List<GameObject>();
        encontrarPlataformas();
        //                      GameObject              Position                        Rotation
        var plataformaInicio = Instantiate(elementoInicial, puntoInicial.position, puntoInicial.rotation);
        Debug.Log("Inicio: " + plataformaInicio);
        Transform destino = plataformaInicio.transform.GetChild(1); ;
        Debug.Log("Destino: " + destino);
        int numeroAleatorio = Random.Range(0, mapa.Count);
        var elementoAleatorio = mapa[numeroAleatorio];
        Debug.Log("Siguiente elemento: " + elementoAleatorio);
        var s = Instantiate(elementoAleatorio, destino.position, destino.rotation);
        Debug.Log("Resultado: " +   s);
        elementoActual = s;

    }

    void encontrarPlataformas()
    {
        var plataforma1 = GameObject.Find("Pasillo Arbol");
        mapa.Add(plataforma1);
        var plataforma2 = GameObject.Find("PasilloRoca");
        mapa.Add(plataforma2);
        var plataforma3 = GameObject.Find("PlataformaInicial");
        mapa.Add(plataforma3);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void juegoEnPausa()
    {

    }

    public override void juegoRestaurado()
    {

    }
}