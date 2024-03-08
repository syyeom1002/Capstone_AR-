using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabledestroy : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "desk")
            Destroy(gameObject);

    }
}
