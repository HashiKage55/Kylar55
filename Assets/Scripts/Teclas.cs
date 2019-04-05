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
    public Canvas error;
    private Boolean esperarATeclaDeSalto= false;
    private Boolean esperarATeclaDeDer = false;
    private Boolean esperarATeclaDeIzq = false;
    private Boolean esperarATeclaDeRueda = false;
    public static KeyCode KeyCode;
    public List<KeyCode> keys;
    private bool Duplicados;



    // Use this for initialization
    void Start () {
        botonSalto.onClick.AddListener(jumpRebind);
        botonDer.onClick.AddListener(RightRebind);
        botonIzq.onClick.AddListener(LeftRebind);
        botonRueda.onClick.AddListener(RollRebind);
        panel.enabled = false;
        error.enabled = false;
        keys = new List<KeyCode>();
        registrarTeclas(ValorOpciones.JUMP_BUTTON);
        registrarTeclas(ValorOpciones.RIGHT_BUTTON);
        registrarTeclas(ValorOpciones.LEFT_BUTTON);
        registrarTeclas(ValorOpciones.ROLL_BUTTON);
        


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
            if (evento.keyCode != KeyCode.None) { 
            Debug.Log("Pulsado: " + evento.keyCode);
            
            Duplicados = NoDuplicados(evento.keyCode);
            if (Duplicados == true) {
                panel.enabled = false;
                error.enabled = true;
            } else {
                error.enabled = false;
                keys.Remove(ValorOpciones.JUMP_BUTTON);
                ValorOpciones.JUMP_BUTTON = evento.keyCode;
                keys.Add(ValorOpciones.JUMP_BUTTON);
                esperarATeclaDeSalto = false;
                PlayerPrefs.SetString("botonSalto", ValorOpciones.JUMP_BUTTON.ToString());
                panel.enabled = false;
               
               
            }
            }
        }
            if (evento.keyCode != KeyCode.None)
            {
            if (evento.isKey && esperarATeclaDeDer)
        {
            Debug.Log("Pulsado: " + evento.keyCode);
            Duplicados = NoDuplicados(evento.keyCode);
            if (Duplicados == true)
            {
                panel.enabled = false;
                error.enabled = true;
            }
            else
            {
                error.enabled = false;
                ValorOpciones.RIGHT_BUTTON = evento.keyCode;
                esperarATeclaDeDer = false;
                PlayerPrefs.SetString("botonDer", ValorOpciones.RIGHT_BUTTON.ToString());
                panel.enabled = false;
               
               
            }
            }
        }
            if (evento.keyCode != KeyCode.None)
            {
            if (evento.isKey && esperarATeclaDeIzq)
        {
            Debug.Log("Pulsado: " + evento.keyCode);
            Duplicados = NoDuplicados(evento.keyCode);
            if (Duplicados == true) {
                panel.enabled = false;
                error.enabled = true;
            } else {
                error.enabled = false;
                ValorOpciones.LEFT_BUTTON = evento.keyCode;
                esperarATeclaDeIzq = false;
                PlayerPrefs.SetString("botonIzq", ValorOpciones.LEFT_BUTTON.ToString());
                panel.enabled = false;
                
                
            }
            }
        }
            if (evento.keyCode != KeyCode.None)
            {
            if (evento.isKey && esperarATeclaDeRueda)
        {
            Debug.Log("Pulsado: " + evento.keyCode);
            Duplicados = NoDuplicados(evento.keyCode);
            if (Duplicados == true)
            {
                panel.enabled = false;
                error.enabled = true;
            }
            else
            {
                error.enabled = false;
                ValorOpciones.ROLL_BUTTON = evento.keyCode;
                esperarATeclaDeRueda = false;
                PlayerPrefs.SetString("botonVoltereta", ValorOpciones.ROLL_BUTTON.ToString());
                panel.enabled = false;
                
                
                
            }
            }

        }
        PlayerPrefs.Save();
        

    }
    public void registrarTeclas(KeyCode KeyCode)
    {
        keys.Add(KeyCode);
    }
    public void quitarTeclas(KeyCode KeyCode)
    {
        keys.Remove(KeyCode);
    }
    bool NoDuplicados(KeyCode tecla)
    {
        foreach (KeyCode c in keys)
        {
            if (c == tecla)
            {
                Debug.Log("Encontre");
                return true;
                
            }
        }
        Debug.Log("No Encontre");
        
        return false;
        


    }



}