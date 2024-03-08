using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helix004move : MonoBehaviour
{
    public new Rigidbody rigidbody;
    public float speed = 3f;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Invoke("Spin", 1f);
        rigidbody.angularVelocity = Vector3.zero;
    }

    // Update is called once per frame
    void Spin()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
        transform.Rotate(0, 0, 10);

    }
}
