using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Scape MiScape;
    private int resultado;
  
    //informacion necesaria para la interfaz de usuario
   

    
    // Start is called before the first frame update
    void Start()
    {
        MiScape = new Scape();
        //inicio los valores de la interfaz
    }

    // Update is called once per frame
    void Update()
    {
        if (MiScape.dimePuntos() > 0)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow)) // pulsa tecla de subir.
            {
                resultado = MiScape.subir();
                
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow)) // pulsa la tecla de abajo.
            {
                resultado = MiScape.bajar();
               
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))// pulsa la tecla de derecha.
            {
                resultado = MiScape.Derecha();
               
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow)) // pulsa la tecla de izquierda.)
            {
                resultado = MiScape.Izquierda();
              
            }

                      
        }
        
    }
}
