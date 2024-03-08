using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screw10move2 : MonoBehaviour
{
    public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Move", 12f);
    }
    void Move()
    {
        transform.Translate((Vector3.forward) * Time.deltaTime * speed);
        transform.Rotate(0, 0, 10);
    }
}
