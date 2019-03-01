using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneracionPlataformas : ControladorBasico {

    public GameObject elementoInicial;
    public GameObject elementoSiguiente;
    public GameObject elementoSiguiente2;
    public Transform puntoInicio;
    public int sizeOfList;

    public List<GameObject> plataformas = new List<GameObject>();


    //public Transform puntoSiguiente;

    // Use this for initialization
    void Start () {
        base.Start();



        sizeOfList = plataformas.Count;
        


        


        //var plataformaInicio = Instantiate(elementoInicial, puntoInicio.position, puntoInicio.rotation);
        //Instantiate(elementoSiguiente, puntoSiguiente.position, puntoSiguiente.rotation);
        //Transform destino = plataformaInicio.gameObject.transform.Find("puntoAnclado");
       // var elemento1 = Instantiate(elementoSiguiente, destino.position, destino.rotation);
       // Transform destino2 = elemento1.gameObject.transform.Find("puntoAnclado2");
        //Instantiate(elementoSiguiente2, destino2.position, destino2.rotation);//
    }
    
    

    // Update is called once per frame
    void Update () {
		
	}
    public override void juegoEnPausa()
    {
        throw new System.NotImplementedException();
    }
    public override void juegoRestaurado()
    {
        throw new System.NotImplementedException();
    }
}
