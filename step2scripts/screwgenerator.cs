using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screwgenerator : MonoBehaviour
{
    public float speed = 3.0f;
    void Start()
    {

    }
    void Update()
    {
        Invoke("Spin", 6f);
    }

    // Update is called once per frame
    void Spin()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);

    }

}
