using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step9tool : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime, Space.World);
        transform.Rotate(0,5,0);

    }
}
