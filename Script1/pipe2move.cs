using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe2move : MonoBehaviour
{
    public float speed = 3f;
    void Start()
    {

    }

    void Update()
    {
        Invoke("Spin", 10f);
    }

    // Update is called once per frame
    void Spin()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
        transform.Rotate(8, 0, 0);

    }
}
