using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void ClickAction();
    public static event ClickAction OnClicked;


    void OnGUI()
    {
        if(Input.GetKeyDown("space"))
        {
            if (OnClicked != null)
                OnClicked();
        }
    }


}
