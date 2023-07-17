using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zoo2 : MonoBehaviour
/// <sumary>
/// se utilizan comúnmente para definir comportamientos de componentes que se pueden agregar a objetos en la escena de Unity
{
      public void CambiarEscena(string nombreEscena)
      /// <sumary>
      ///Esta clase se encargaría de manejar la lógica del juego y gestionar las escenas
    {
        SceneManager.LoadScene(nombreEscena);
    }
}

