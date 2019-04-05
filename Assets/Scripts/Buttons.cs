using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class Buttons : MonoBehaviour
{
    public Button btnPlay, btnOptions, btnQuit, btnLeaveToTitle, btnContinue;
    public EstadoJuego estado;
    public List<ControladorBasico> controladores;
    public static GameController controlador;

    // Use this for initialization
    void Start()
    {
        btnPlay.onClick.AddListener(Play);
        btnQuit.onClick.AddListener(Quit);
        btnOptions.onClick.AddListener(Options);
        btnLeaveToTitle.onClick.AddListener(LeaveToTitle);
        btnContinue.onClick.AddListener(Continue);


    }
    void TaskOnClick()
    {
        SceneManager.LoadScene("asasas");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Play()
    {
        SceneManager.LoadScene("Play");
    }
    void Quit()
    {
        Application.Quit();
    }
    void Options()
    {
        SceneManager.LoadScene("Options");

    }
    void LeaveToTitle()
    {
        SceneManager.LoadScene("asasas");
    }
    void Continue()
    {
        restaurarJuego();
    }
    void restaurarJuego()
    {
        estado = EstadoJuego.Jugando;
        foreach (ControladorBasico c in controladores)
        {
            c.juegoRestaurado();
        }
    }
}