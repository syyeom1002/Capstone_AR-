using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step5screw : MonoBehaviour
{
    public new Rigidbody rigidbody;
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
        transform.Rotate(0, 0, 10);
        rigidbody.angularVelocity = Vector3.zero;
    }


}
