using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class felisig : MonoBehaviour
/// <summary>
/// Clase que representa un objeto felisig en el juego
{
    public void CambiarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
        /// <summary>
        /// Este método carga una nueva escena en el juego utilizando el nombre proporcionado como parámetro

    }
}
