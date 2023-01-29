using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolver : Pistola
{ 
    public Revolver()
    {
        damage = 30;
        distancia = 10;
        cooldown = 1.5f;
    }
}
