using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxmover : MonoBehaviour
{

    public float speed = 3.0f;
    void Start()
    {
        //SpawnObj�Լ��� ������ ����� 0.1�� �Ŀ� ȣ��, ���� interval�� ���� ȣ�� �ȴ�.
        
    }

    //SpawnObj�Լ��� ChickBallPrefab�� �����Ѵ�.
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);
        
    }
}
