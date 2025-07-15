using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Manager : MonoBehaviour
{
    [Header("Trigger Type")]
    public bool cenario;
    public bool evento;
    public bool door;

    [Header("Interactable Object")]
    public GameObject tunel;

    [Header("tunel")]
    [SerializeField]
    float speed;
    [SerializeField]
    Vector3 rotation = new Vector3();

    [SerializeField]
    bool canStop;

    private void Start()
    {
        canStop = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (cenario)
            {
                rotateTunnel(tunel);
            }
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (cenario)
            {
                //stopTunnel(tunel);
            }
        }
    }

    private void rotateTunnel(GameObject tunel)
    {
        if(tunel.transform.localEulerAngles.x < -1 || tunel.transform.localEulerAngles.x > 0.1)
        {
            tunel.transform.Rotate(rotation * speed * Time.deltaTime);
        }
        else
        {
            tunel.transform.Rotate(0, 0, 0);
        }
        
    }

}
