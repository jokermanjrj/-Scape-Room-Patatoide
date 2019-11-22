using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celda 
{
    private bool salida;
    private int daño;
    public Celda(int daño)
    {
        this.daño = daño;
        this.salida = false;
    }

    public bool esSalida()
    {
        return this.salida;
    }

    public void setSalida()
    {
        this.salida = true;
    }

    public int getdaño()
    {
        return this.daño;
    }


}
