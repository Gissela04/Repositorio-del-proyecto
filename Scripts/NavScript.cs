using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class NavScript : MonoBehaviour
/// <summary>
/// Componente para controlar la navegación de un personaje en el juego

{
    public Text btnNavegacion;
    public string escena;
    /// <summary>
    /// Nombre de la escena a la que se navegará al hacer clic en el botón.
    /// <summary>
    ///  Asegúrate de que el nombre de la escena sea válido


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gotoScene(){
        SceneManager.LoadScene(escena);
        /// <summary>
        /// Cambia a una escena específica del juego cuando se llama a este método.

    } 
}
