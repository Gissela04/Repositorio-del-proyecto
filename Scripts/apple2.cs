using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class apple2 : MonoBehaviour
/// <summary>
/// Esta clase hereda de MonoBehaviour, lo que permite que el objeto interactúe con el motor de Unity y reciba eventos
{
  private void OnTriggerEnter2D(Collider2D collision)
  /// <summary>
  /// Este método se ejecuta automáticamente cuando un objeto con un Collider2D entra en contacto con el objeto que contiene este script
  /// </summary>.
  /// <param name="collision">El Collider2D que representa al colisionador del objeto que ha entrado en contacto.</param>
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(6);
        }
    }
}