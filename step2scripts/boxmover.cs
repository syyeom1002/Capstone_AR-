using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxmover : MonoBehaviour
{

    public float speed = 3.0f;
    void Start()
    {
        //SpawnObj함수를 게임이 실행된 0.1초 후에 호출, 이후 interval초 마다 호출 된다.
        
    }

    //SpawnObj함수는 ChickBallPrefab을 생성한다.
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);
        
    }
}
