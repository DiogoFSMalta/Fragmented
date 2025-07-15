using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterPortal : MonoBehaviour
{
    public GameObject[] destroyLevel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for(int a = 0; a < destroyLevel.Length; a++)
            {
                Destroy(destroyLevel[a]);
            }
        }
    }
}
