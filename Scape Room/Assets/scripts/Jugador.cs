using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador
{

    private string name;
    private int x, y, puntos;

   public Jugador (int x, int y) //constructor
    {
        this.x = x;
        this.y = y;
        puntos = 50;
    }

    public int dimepuntos()
    {
        return puntos;
    }

    public void decrementa (int valor)
    {
        puntos -= valor;
    }

    public int getx()
    {
        return this.x;
    }
    public int gety()
    {
        return this.y;
    }
    public void setx(int x)
    {
        this.x = x;
    }

    public void sety(int y)
    {
        this.y = y;
    }

    public string poisicion()
    {
        return "mi posición en x es " + this.x + ", y en y es: " + this.y;
    }
}
