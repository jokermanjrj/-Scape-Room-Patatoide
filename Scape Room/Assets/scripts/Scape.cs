using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scape : MonoBehaviour
{
    private Celda[,] tablero;
    private const int tamaño = 10;
    private const int Max_daño = 5;
    private Jugador mijugador;


    public Scape()
    {
        int i, j;  // recorrer el array

        //creo tablero
        tablero = new Celda[tamaño, tamaño];

        //asigno daños
        for (i = 0; i < tamaño; i++)
        {
            for (j = 0; j < tamaño; j++)
            {
                tablero[i, j] = new Celda(Random.Range(0, Max_daño));
            }
        }

        //asigno la salida

        tablero[Random.Range(0, 11), Random.Range(0, 11)].setSalida();

        //creo al jugador y le asigno una posiciion aleatoria.
        mijugador = new Jugador(Random.Range(0, 11), Random.Range(0, 11));


    }

    public int subir()
    {
        int posy;
        posy = mijugador.gety();
        if (posy + 1 < 10)
        {
            mijugador.sety(posy + 1);
            mijugador.decrementa(tablero[mijugador.getx(), mijugador.gety()].getdaño());
        }
        return Estado();
    }

    public int bajar()
    {
        int posy;
        posy = mijugador.gety();
        if (posy  - 1  > 0)
        {
            mijugador.sety(posy - 1);
            mijugador.decrementa(tablero[mijugador.getx(), mijugador.gety()].getdaño());
        }
        return Estado();
    }
    public int Derecha()
    {
        int posx;
        posx = mijugador.getx();
        if (posx + 1   < 10)
        {
            mijugador.setx(posx + 1);
            mijugador.decrementa(tablero[mijugador.getx(), mijugador.gety()].getdaño());
        }
        return Estado();
    }

    public int Izquierda()
    {
        int posx;
        posx = mijugador.getx();
        if (posx - 1 > 0)
        {
            mijugador.setx(posx - 1);
            mijugador.decrementa(tablero[mijugador.getx(), mijugador.gety()].getdaño());
        }
        return Estado();
    }

    public int Estado()
    {
        //devuelve 0 si sigue jungando.
        //devuelve 1 si está en la salida.
        //devuelve 2 si ha perdido.

        if (mijugador.dimepuntos() < 1)
        {
            return 2;

        }
        else if (tablero[mijugador.getx(), mijugador.gety()].esSalida())
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
   
        
public int dimePuntos()
    {
       return mijugador.dimepuntos();
    }
       
   
}
