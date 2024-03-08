using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject obj; 
    public float interval = 100.0f; //다음에 함수가 호출될 인터벌
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObj", 5f, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObj()
    {
        Instantiate(obj, transform.position, Quaternion.Euler(0f, 90.0f, 0f));
    }
}
