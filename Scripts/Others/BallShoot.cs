using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShoot : MonoBehaviour
{
    [SerializeField]
    Vector3 movement;
    public float speed;

    public float timeUntilDestroy;
    float destroy = 0;

    private void Start()
    {
        this.transform.localScale = new Vector3(0, 0, 0);
    }

    void Update()
    {
        transform.position += movement * speed * Time.deltaTime;

        if(this.transform.localScale != new Vector3(2f, 2f, 2f))
        {
            transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
        }

        if(destroy < timeUntilDestroy)
        {
            destroy += Time.deltaTime;
        }

        if(destroy >= timeUntilDestroy)
        {
            Destroy(gameObject);
        }
    }
}
