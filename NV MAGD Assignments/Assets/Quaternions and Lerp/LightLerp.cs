using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightLerp : MonoBehaviour
{
   public float smooth = 2;
   private Vector3 newPosition;
   private Color newColor;

   void Awake()
   {
        newPosition = transform.position;
        newColor = GetComponent<Light>().color;
   }

   void Update()
   {
        PositionChanging();
   }

   void PositionChanging()
   {
    Vector3 positionA = new Vector3(-2, 1, 0);
    Vector3 positionB = new Vector3(2, 1, 0);
    Color colorA = Color.red;
    Color colorB = Color.green;

    if(Input.GetKeyDown(KeyCode.P))
        newPosition = positionA;
    if(Input.GetKeyDown(KeyCode.O))
        newPosition = positionB;
    if(Input.GetKeyDown(KeyCode.Z))
        newColor = colorA;
    if(Input.GetKeyDown(KeyCode.C))
        newColor = colorB;


        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * smooth);
        GetComponent<Light>().color = Color.Lerp(GetComponent<Light>().color, newColor, Time.deltaTime * smooth);
   }
}