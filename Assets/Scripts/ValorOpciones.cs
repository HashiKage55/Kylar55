
using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public static class ValorOpciones
{
    
    public static KeyCode DEFAULT_JUMP_BUTTON = KeyCode.Space;

    /**/
    public static KeyCode JUMP_BUTTON = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("botonSalto", KeyCode.Space.ToString()));

    public static KeyCode DEFAULT_RIGHT_BUTTON = KeyCode.RightArrow;

    /**/
    public static KeyCode RIGHT_BUTTON = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("botonDer", KeyCode.RightArrow.ToString()));

    public static KeyCode DEFAULT_LEFT_BUTTON = KeyCode.LeftArrow;

    /**/
    public static KeyCode LEFT_BUTTON = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("botonIzq", KeyCode.LeftArrow.ToString()));

    public static KeyCode DEFAULT_ROLL_BUTTON = KeyCode.LeftShift;

    /**/
    public static KeyCode ROLL_BUTTON = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("botonRueda", KeyCode.LeftShift.ToString()));

    
}
