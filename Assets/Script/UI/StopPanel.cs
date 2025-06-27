using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPanel : MonoBehaviour
{
    public GameObject stoppanel;
    // Start is called before the first frame update
    void Start()
    {
        stoppanel = GameObject.Find("Stopping");
        stoppanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
