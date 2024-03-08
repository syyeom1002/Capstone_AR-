using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helixmove : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Move", 6f);
    }
    void Move()
    {
        transform.Translate((Vector3.back) * Time.deltaTime * speed);
        transform.Rotate(0, 0, 10);
    }
}
