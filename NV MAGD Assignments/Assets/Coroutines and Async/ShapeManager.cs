using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeManager : MonoBehaviour
{
    [SerializeField] private Shape shapes;

    public void BeginTest(){
        StartCoroutine(shapes.MoveForSeconds(5));
    }
}
