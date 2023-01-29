using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistola 
{
    public float damage { get; set; }
    public int distancia { get; set; }
    public float cooldown { get; set; }

    private float lastFireTime;

 /// <summary>
 /// Comprueba si ha pasado el tiempo suficiente para volver a disparar
 /// </summary>
 /// <returns>Puede disparar o no puede</returns>
    public bool Disparar()
    {
        if (Time.time - lastFireTime >= cooldown)
        {
            lastFireTime = Time.time;
          
            return true;
        }
        return false;
    }
}
