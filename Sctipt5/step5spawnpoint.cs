using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step5spawnpoint : MonoBehaviour
{
    public GameObject obj;
    public float interval = 100.0f; //������ �Լ��� ȣ��� ���͹�
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObj", 0.1f, interval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObj()
    {
        Instantiate(obj, transform.position, Quaternion.Euler(0f,0f, 0f));
    }
}
