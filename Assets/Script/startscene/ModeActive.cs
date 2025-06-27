using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeActive : MonoBehaviour
{
    GameObject mode;
    // Start is called before the first frame update
    void Start()
    {
        mode = GameObject.Find("Mode");
        mode.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
