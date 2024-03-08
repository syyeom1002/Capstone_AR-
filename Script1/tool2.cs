using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tool2 : MonoBehaviour
{
    public float speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Pipe2", 15f);
    }
    void Pipe2()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
        transform.Rotate(5, 0, 0);
    }
}
