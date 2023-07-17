using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class v : MonoBehaviour
/// <summary>
///brief Contiene la definición de la clase v.

///  La clase v se utiliza para agrega una breve descripción del propósito y uso de la clase.
{
    public void CambiarEscena(string nombreEscena)
    /// <summary>
    ///Cambia a una escena específica del juego.
    {
        SceneManager.LoadScene(nombreEscena);
        /// <summary>
        ///Esta función pertenece al sistema de administración de escenas de Unity y se utiliza para cambiar entre diferentes escenas en tu juego
    }
}
