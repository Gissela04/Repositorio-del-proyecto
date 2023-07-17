using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opcion_2 : MonoBehaviour
/// <summary>
/// Clase que representa la opción 1 en el juego
{
    public void CambiarEscena(string nombreEscena)
    /// <summary>
    /// Gestiona el cambio a la escena especificada por el nombre
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
