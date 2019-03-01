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
        Transform destino = plataformaInicio.gameObject.transform.Find("p");
        Debug.Log("Destino: " + destino);
        int numeroAleatorio = Random.Range(0, mapa.Count);
        var elementoAleatorio = mapa[numeroAleatorio];
        Debug.Log("Siguiente elemento: " + elementoAleatorio);
        elementoActual = Instantiate(elementoAleatorio, destino.position, destino.rotation);

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