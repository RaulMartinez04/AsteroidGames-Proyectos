using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    //Metodo para iniciar el juego
    public void jugarJuego(){
        SceneManager.LoadScene(1);
    }

    //Metodo para ver las instrucciones del juego
    public void instruccionesJuego(){
        SceneManager.LoadScene(2);
    }

    //Metodo para ver el concept art del juego
    public void arteJuego(){
        SceneManager.LoadScene(3);
    }

    //Metodo para volver al menu del juego
    public void menuJuego(){
        SceneManager.LoadScene(0);
    }

    //Metodo para reiniciar el juego
    public void reiniciarJuego(){
        SceneManager.LoadScene(1);
    }
}
