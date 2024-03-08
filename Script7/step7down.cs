using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step7down : MonoBehaviour
{
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Move", 1f);
    }
    void Move()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
    }
}
