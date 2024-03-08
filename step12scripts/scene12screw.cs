using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene12screw : MonoBehaviour
{
    public float speed = 3f;
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
        transform.Translate(Vector3.down*speed * Time.deltaTime, Space.World);
        transform.Rotate(0, 0, 10);

    }
}
