using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Teclas : MonoBehaviour {
    public Button botonSalto;
    public Button botonDer;
    public Button botonIzq;
    public Button botonRueda;
    public Canvas panel;
    private Boolean esperarATeclaDeSalto= false;
    private Boolean esperarATeclaDeDer = false;
    private Boolean esperarATeclaDeIzq = false;
    private Boolean esperarATeclaDeRueda = false;



    // Use this for initialization
    void Start () {
        botonSalto.onClick.AddListener(jumpRebind);
        botonDer.onClick.AddListener(RightRebind);
        botonIzq.onClick.AddListener(LeftRebind);
        botonRueda.onClick.AddListener(RollRebind);
        panel.enabled = false;
        
    }
	
	// Update is called once per frame
	void Update () {
        botonSalto.GetComponentInChildren<Text>().text = ValorOpciones.JUMP_BUTTON.ToString();
        botonDer.GetComponentInChildren<Text>().text = ValorOpciones.RIGHT_BUTTON.ToString();
        botonIzq.GetComponentInChildren<Text>().text = ValorOpciones.LEFT_BUTTON.ToString();
        botonRueda.GetComponentInChildren<Text>().text = ValorOpciones.ROLL_BUTTON.ToString();
    }

    void jumpRebind()
    {
        panel.enabled = true;
        esperarATeclaDeSalto = true;
    }
    void RightRebind()
    {
        panel.enabled = true;
        esperarATeclaDeDer = true;
    }
    void LeftRebind()
    {
        panel.enabled = true;
        esperarATeclaDeIzq = true;
    }
    void RollRebind()
    {
        panel.enabled = true;
        esperarATeclaDeRueda = true;
    }

    private void OnGUI()
    {
        var evento = Event.current;
        if (evento.isKey && esperarATeclaDeSalto)
        {
            Debug.Log("Pulsado: " + evento.keyCode);
            ValorOpciones.JUMP_BUTTON = evento.keyCode;
            esperarATeclaDeSalto = false;
            PlayerPrefs.SetString("botonSalto", ValorOpciones.JUMP_BUTTON.ToString());
            panel.enabled = false;
        }
        if (evento.isKey && esperarATeclaDeDer)
        {
            Debug.Log("Pulsado: " + evento.keyCode);
            ValorOpciones.RIGHT_BUTTON = evento.keyCode;
            esperarATeclaDeDer = false;
            PlayerPrefs.SetString("botonDer", ValorOpciones.RIGHT_BUTTON.ToString());
            panel.enabled = false;
        }
        if (evento.isKey && esperarATeclaDeIzq)
        {
            Debug.Log("Pulsado: " + evento.keyCode);
            ValorOpciones.LEFT_BUTTON = evento.keyCode;
            esperarATeclaDeIzq = false;
            PlayerPrefs.SetString("botonIzq", ValorOpciones.LEFT_BUTTON.ToString());
            panel.enabled = false;
        }
        if (evento.isKey && esperarATeclaDeRueda)
        {
            Debug.Log("Pulsado: " + evento.keyCode);
            ValorOpciones.ROLL_BUTTON = evento.keyCode;
            esperarATeclaDeRueda = false;
            PlayerPrefs.SetString("botonRueda", ValorOpciones.ROLL_BUTTON.ToString());
            panel.enabled = false;
        }
        PlayerPrefs.Save();
    }
    


}