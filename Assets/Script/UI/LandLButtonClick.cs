using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class LandLButtonClick : MonoBehaviour
{
    public bool LButton;
    public float movespeed;
    GameObject speed;

    void Start()
    {
        speed = GameObject.Find("character");
        movespeed = speed.GetComponent<character>().movespeed;
    }
    void Update()
    {
        movespeed = speed.GetComponent<character>().movespeed;
        if (transform.position.x < -8.51)
        {
            LButton = false;
        }
        if (LButton)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            transform.Translate(Vector3.left * movespeed);
        }
    }

    public void PointerDown()
    {
        LButton = true;
    }

    public void PointerUp()
    {
        LButton = false;
    }

}