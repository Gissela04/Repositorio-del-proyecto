using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opcion_1 : MonoBehaviour
/// <summary>
/// Clase que representa la opción 1 en el juego
{
    public void CambiarEscena(string nombreEscena)
    /// <summary>
    /// Aquí se realiza la lógica para cambiar a la escena especificada por el nombre.
    {
        SceneManager.LoadScene(nombreEscena);
    }
}