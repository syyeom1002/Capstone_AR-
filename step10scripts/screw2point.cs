using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screw2point : MonoBehaviour
{
    public GameObject obj; //ChickBallPrefab 설정


    void Start()
    {
        //SpawnObj함수를 게임이 실행된 0.1초 후에 호출, 이후 interval초 마다 호출 된다.
        Invoke("SpawnObj", 3f);
    }

    //SpawnObj함수는 ChickBallPrefab을 생성한다.
    void SpawnObj()
    {
        Instantiate(obj, transform.position, transform.rotation);
    }
}
