using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Action_Controller : MonoBehaviour
{
    private ActionBasedController controller;

    public GameObject balaPrefab;
    public Transform spawnPoint; // Punto de spawn de la bala

    public GameObject Rifle;
    public GameObject Revolver;

    private bool esRifle = true;
    public Pistola pistola;

    private void Start()
    {
        controller = GetComponent<ActionBasedController>();
        //Callback
        controller.selectAction.action.performed += AccionDisparar;
        controller.activateActionValue.action.performed += CambiaPistola;

        pistola = new Rifle();
    }

    private void AccionDisparar(InputAction.CallbackContext obj)
    {
        if (pistola.Disparar())
        {
            GameObject bala = Instantiate(balaPrefab, spawnPoint.position, spawnPoint.rotation);
            
            bala.GetComponent<Bala>().damage = pistola.damage;
            // Añadimos una fuerza la bala instanciada
            bala.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * pistola.distancia, ForceMode.Impulse);
        }
    }

    private void CambiaPistola(InputAction.CallbackContext obj)
    {
        esRifle = !esRifle;
        Rifle.SetActive(esRifle);
        Revolver.SetActive(!esRifle);

        if (esRifle)
        {
            pistola = new Rifle();
        }
        else
        {
            pistola = new Revolver();
        }
    }
}
