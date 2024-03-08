using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinder1mover : MonoBehaviour
{
    public new Rigidbody rigidbody;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Move", 1f);
        rigidbody.angularVelocity = Vector3.zero;

    }
    void Move()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
    }
}
