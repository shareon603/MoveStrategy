using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleModeActive : MonoBehaviour
{
    GameObject mapmode;
    // Start is called before the first frame update
    void Start()
    {
        mapmode = GameObject.Find("MapMode");

        if (mapmode == null)
        {
            Debug.Log("sda");
        }
        mapmode.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
