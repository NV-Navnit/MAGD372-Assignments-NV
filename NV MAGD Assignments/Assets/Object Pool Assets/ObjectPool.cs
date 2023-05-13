using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject objectToPool;//What we want to create copies of


    public List<GameObject> thePool = new List<GameObject>();//List of objects to keep track of

    public int startAmount;//How many objects we want to instantiate at the start

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < startAmount; i++)
        {
            thePool.Add(Instantiate(objectToPool));
            thePool[i].SetActive(false);
            thePool[i].transform.parent = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject SpawnObject(Vector3 position, Quaternion rotation)
    {
        GameObject toReturn;


        if(thePool.Count > 0)
        {
            toReturn = thePool[0];
            thePool.RemoveAt(0);
        } else
        {
            toReturn = Instantiate(objectToPool);
            toReturn.transform.parent = transform;
        }

        toReturn.SetActive(true);
        toReturn.transform.position = position;
        toReturn.transform.rotation = rotation;
        return toReturn;
    }

    public void ReturnObject(GameObject objectToReturn)
    {
        thePool.Add(objectToReturn);
        objectToReturn.SetActive(false);
    }

}
