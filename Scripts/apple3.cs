using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class apple3 : MonoBehaviour
/// <summary>
/// Clase que representa un objeto "manzana" en el juego
{
    private void OnTriggerEnter2D(Collider2D collision)
    /// <summary>
  /// Este método se ejecuta automáticamente cuando un objeto con un Collider2D entra en contacto con el objeto que contiene este script
  /// </summary>.
  /// <param name="collision">El Collider2D que representa al colisionador del objeto que ha entrado en contacto.</param>
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(10);
        }
    }
}
