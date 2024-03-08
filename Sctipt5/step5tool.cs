using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step5tool : MonoBehaviour
{
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Invoke("Spin", 5f);
        transform.Translate(Vector3.down*speed * Time.deltaTime, Space.World);
        transform.Rotate(5, 0, 0);
    }

}
