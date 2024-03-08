using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step9screw2 : MonoBehaviour
{
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        Invoke("Spin", 11f);
    }

    // Update is called once per frame
    void Spin()
    {
        transform.Translate(Vector3.forward*speed * Time.deltaTime, Space.World);
        transform.Rotate(0, 0, 10);

    }
}
