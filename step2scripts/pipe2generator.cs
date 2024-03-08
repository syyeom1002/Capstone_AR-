using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe2generator : MonoBehaviour
{
    public float speed = 4f;
    void Start()
    {

    }

    void Update()
    {
        Invoke("Spin", 15f);
    }

    // Update is called once per frame
    void Spin()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
        transform.Rotate(8, 0, 0);

    }
}
