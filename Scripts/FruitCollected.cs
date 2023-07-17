using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollected : MonoBehaviour
/// <summary>
/// Se encarga de gestionar la recolección de frutas en el juego.
{
     private void OnTriggerEnter2D(Collider2D collision)
    /// <summary>
    /// Método que se activa automáticamente cuando un objeto colisiona con el colisionador 2D de este objeto.

    {
        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject, 0.5f);
            /// <summary>
            /// Desactiva el componente SpriteRenderer del objeto
            /// Activa el primer hijo del objeto
            /// Destruye el objeto después de un tiempo especificado (0.5 segundos en este caso)
           
        }
    }
}
