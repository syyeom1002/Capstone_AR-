using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screw2point : MonoBehaviour
{
    public GameObject obj; //ChickBallPrefab ����


    void Start()
    {
        //SpawnObj�Լ��� ������ ����� 0.1�� �Ŀ� ȣ��, ���� interval�� ���� ȣ�� �ȴ�.
        Invoke("SpawnObj", 3f);
    }

    //SpawnObj�Լ��� ChickBallPrefab�� �����Ѵ�.
    void SpawnObj()
    {
        Instantiate(obj, transform.position, transform.rotation);
    }
}
