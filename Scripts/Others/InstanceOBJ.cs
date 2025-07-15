using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceOBJ : MonoBehaviour
{
    public float timeUntilShooting;
    float timer = 0;

    public GameObject bullet;

    void Update()
    {
        if(timer < timeUntilShooting)
        {
            timer += Time.deltaTime;
        }

        if(timer >= timeUntilShooting)
        {
            Instantiate(bullet, transform.position, transform.localRotation);
            timer = 0;
        }
    }
}
