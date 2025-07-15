using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    List<GameObject> checkpoints;
    [SerializeField]
    Vector3 vectorPoint;


    void Start()
    {
        vectorPoint = player.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("checkpoint"))
        {
            vectorPoint = player.transform.position;
            Destroy(other.gameObject);
            print("Checkpoint Set");
        }

        if (other.CompareTag("Death"))
        {
            player.transform.position = vectorPoint;
        }
        
    }
}
