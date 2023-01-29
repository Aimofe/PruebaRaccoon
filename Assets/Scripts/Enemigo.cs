using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemigo : MonoBehaviour
{
    [HideInInspector]
    public float vida;
    public float maxVida;

    public Image barra;
    public Text texto;

    public GameObject enemigo;
    void Start()
    {
        vida = maxVida;
    }

    // Update is called once per frame
    void Update()
    {
        barra.fillAmount = vida / maxVida;
        texto.text = vida + "/" + maxVida;
        if (vida<=0)
        {
            Destroy(enemigo);
        }
    }
}
