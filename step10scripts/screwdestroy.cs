using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screwdestroy : MonoBehaviour
{
    public float deleteTime = 4.0f;
    void Start()
    {
        Destroy(gameObject, deleteTime);
    }
}
