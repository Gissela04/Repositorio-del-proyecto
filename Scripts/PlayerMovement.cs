using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
/// <summary>
/// Esta clase se encarga de gestionar el movimiento del jugador en el juego
{
     float horizontalMove = 0;
     float verticalMove = 0;
     /// <summary>
     /// Este valor indica la dirección del movimiento horizontal del jugador
     /// (hacia la derecha) o negativo (hacia la izquierda). Se utiliza en combinación con la velocidad
     /// </summary>
     /// Este valor indica la dirección del movimiento vertical del jugador
     /// (hacia arriba) o negativo (hacia abajo). Se utiliza en combinación con la velocidad



     public float runSpeedHorizontal = 3;
     public float runSpeedVertical = 3;
     public float runSpeed = 0;
      /// <summary>
     /// Esta variable determina la velocidad de movimiento horizontal del jugador cuando está corriendo
     /// </summary>
     /// Esta variable determina la velocidad de movimiento vertical del jugador cuando está corriendo.
     /// <summary>
     /// Esta variable representa la velocidad total de movimiento del jugador cuando está corriendo.

     Rigidbody2D rigidbody2D;

     public Joystick joystick;
     /// <summary>
     /// La variable joystick almacena una referencia al Joystick que se utiliza para controlar el movimiento
     
     // Start is called before the first frame update
     void Start()
     {
       
     }

     // Update is called once per frame
     void Update()
     {
        verticalMove = joystick.Vertical * runSpeedVertical;
        horizontalMove = joystick.Horizontal * runSpeedHorizontal;
         /// <summary>
        /// Almacena la componente horizontal del movimiento del jugador controlado por el Joystick.

        transform.position += new Vector3(horizontalMove, verticalMove, 0) * Time.deltaTime * runSpeed;
        /// <summary>
        ///  Actualiza la posición del jugador en función del movimiento calculado.
     }
}