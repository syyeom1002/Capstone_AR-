using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step2controller2 : MonoBehaviour
{
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    void Update()
    {
        Invoke("Spin", 12f);
    }

    // Update is called once per frame
    void Spin()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);

    }
}
