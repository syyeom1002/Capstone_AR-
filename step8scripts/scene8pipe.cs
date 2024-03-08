using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene8pipe : MonoBehaviour
{
    public float speed = 2f;
    void Start()
    {

    }

    void Update()
    {
        Invoke("Spin", 1f);
    }

    // Update is called once per frame
    void Spin()
    {
        transform.Translate(Vector3.up*speed * Time.deltaTime, Space.World);
        transform.Rotate(8, 0, 0);

    }
}
