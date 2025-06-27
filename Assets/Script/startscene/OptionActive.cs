using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionActive : MonoBehaviour
{
    GameObject description;
    // Start is called before the first frame update
    void Start()
    {
        description = GameObject.Find("Description");


        if (description == null)
        {
            Debug.Log("sda");
        }
        description.SetActive(false);
    }

    public void startOption()
    {
        description.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
