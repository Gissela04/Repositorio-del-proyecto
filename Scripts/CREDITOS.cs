using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CREDITOS : MonoBehaviour
/// <summary>
/// Los créditos se muestran al final del juego para agradecer y dar reconocimiento a las personas involucradas en su creación
{
    public void CambiarEscena(string nombreEscena)
    /// <summary>
    ///  Hay que tener en cuenta que los detalles específicos del código y su implementación pueden variar, así que asegúrate de agregar más comentarios para explicar cada función y variable adicional que agregues
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
