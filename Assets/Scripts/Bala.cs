using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [HideInInspector]
    public float damage;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Enemigo")
        {
            collision.gameObject.GetComponent<Enemigo>().vida -= damage;
        }

        Destroy(gameObject);
    }
}
