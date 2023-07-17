using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kiwi : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    /// <summary>
    /// Función que maneja la colisión cuando un objeto entra en el área de colisión 2D
    {
        if (collision.CompareTag("Player"))
        /// <summary>
        /// Ejecuta acciones relacionadas con la colisión con el jugador
        {
            SceneManager.LoadScene(1);
        }
    }
}
