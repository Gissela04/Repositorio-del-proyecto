using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class f : MonoBehaviour
/// <summary>
/// Clase que representa el comportamiento de un objeto en la escena del juego.

{
    public void CambiarEscena(string nombreEscena)
    /// <summary>
    ///  Cambia a una escena específica del juego.
    /// Este método se encarga de cargar una nueva escena en el juego

    {
        SceneManager.LoadScene(nombreEscena);
        /// <summary>
        /// Carga una nueva escena en el juego
    }
}
