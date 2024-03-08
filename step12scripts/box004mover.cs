using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box004mover : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((Vector3.back) * Time.deltaTime * speed);
    }
}
