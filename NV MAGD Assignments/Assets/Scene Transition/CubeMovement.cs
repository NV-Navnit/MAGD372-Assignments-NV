using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    Vector3 Vec;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            Vec = transform.localPosition;
            Vec.y += Input.GetAxis("Jump") * Time.deltaTime*10;
            Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime *10;
            Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 10;
            transform.localPosition = Vec;
    }
}
