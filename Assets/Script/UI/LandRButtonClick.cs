using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandRButtonClick : MonoBehaviour
{
    public bool RButton;
    public float movespeed;
    GameObject speed = null;
    // Start is called before the first frame update
    void Start()
    {
        speed = GameObject.Find("character");
        movespeed = speed.GetComponent<character>().movespeed;
    }

    // Update is called once per frame
    void Update()
    {
        movespeed = speed.GetComponent<character>().movespeed;
        if (transform.position.x > 7.1)
        {
            RButton = false;
        }
        if (RButton)
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.Translate(Vector3.right * movespeed);
        }
    }
    public void PointerDown()
    {
        RButton = true;
    }
    public void PointerUp()
    {
        RButton = false;
    }

}