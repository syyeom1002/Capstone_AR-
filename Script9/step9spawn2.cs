using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step9spawn2 : MonoBehaviour
{
    public GameObject obj;
    public float interval = 100.0f; //������ �Լ��� ȣ��� ���͹�
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObj", 10f, interval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObj()
    {
        Instantiate(obj, transform.position, Quaternion.Euler(90.0f, 0f, 0f));
    }
}
