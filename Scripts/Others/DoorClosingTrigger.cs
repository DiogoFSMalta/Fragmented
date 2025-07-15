using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClosingTrigger : MonoBehaviour
{
    public Animation doorAnim;

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnim.Play();
            Destroy(gameObject);
        }
    }
}
