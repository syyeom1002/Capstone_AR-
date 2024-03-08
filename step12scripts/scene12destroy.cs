using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene12destroy : MonoBehaviour
{
    public float deleteTime = 6.0f;
    void Start()
    {
        Destroy(gameObject, deleteTime);
    }
}
