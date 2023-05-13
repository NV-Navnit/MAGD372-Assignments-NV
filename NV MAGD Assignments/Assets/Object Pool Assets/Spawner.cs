using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    ObjectPool2 objectPool2;

    // Start is called before the first frame update
    private void Start()
    {
        objectPool2 = ObjectPool2.Instance;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        objectPool2.SpawnFromPool("Cube", transform.position, Quaternion.identity);
    }
}
