using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [Header("Rotate")]
    public Vector3 rotation;
    public float speed;

    

      void Update()
    {
        transform.Rotate(rotation * speed * Time.deltaTime);

    }
}
