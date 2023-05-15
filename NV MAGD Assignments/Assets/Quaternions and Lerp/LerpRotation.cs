using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpRotation : MonoBehaviour
{
   Vector3 relativePosition;
   Quaternion targetRotation;

   bool rotating = false;

   float rotationTime;

   public Transform target;
   public float speed = 0.1f;
   void Update(){
    //if(Input.GetKeyDown(KeyCode.Space)){
    
    relativePosition = target.position - transform.position;
    targetRotation = Quaternion.LookRotation(relativePosition);
    rotating = true;
    rotationTime = 0;

   // }
    if(rotating){
        rotationTime += Time.deltaTime * speed;
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationTime);
    }
    if(rotationTime > 1){
        rotating = false;
    }
   }
}
