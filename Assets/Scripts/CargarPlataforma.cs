using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CargarPlataforma : MonoBehaviour {
    public int sizeOfList;
    List<GameObject> lista;
    public int elementoSiguiente;

    // Use this for initialization
    void Start () {
        
        GameObject Random = GameObject.Find("ControladorMapa");
        GeneracionPlataformas Control = Random.GetComponent<GeneracionPlataformas>();
        lista = Control.plataformas;
        sizeOfList = lista.Count;
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider Player)
    {
        Debug.Log(Random.Range(0, sizeOfList));
        elementoSiguiente = (Random.Range(0, sizeOfList));
        Debug.Log(lista[elementoSiguiente]);
        
    }
}
