using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe1deletetime : MonoBehaviour
{
    public float deleteTime = 6.0f;
    void Start()
    {
        Destroy(gameObject, deleteTime);
    }

}
