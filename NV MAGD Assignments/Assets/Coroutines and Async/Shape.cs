using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public IEnumerator MoveForSeconds(float duration)
    {
        float horizontalInput = Input.GetAxis("Horizontal");

       var end = Time.time + duration;
       while (Time.time < end)
        {
            transform.position = transform.position + new Vector3(horizontalInput * 2 * Time.deltaTime, 0, 0);
            yield return null;
            
        }


    }

    /* public IEnumerator ChangeColor()
    {
        Renderer ren;
        if (Input.GetKey("up"))
        {
            ren = GetComponent<Renderer>();
            ren.material.color=Color.white;
        }


    }*/
    
}
