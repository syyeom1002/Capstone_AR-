using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tool1 : MonoBehaviour
{
    public float speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        Invoke("Pipe", 5f);
        
    }
    void Pipe()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
        transform.Rotate(5, 0, 0);
    }
    // Update is called once per frame
}
