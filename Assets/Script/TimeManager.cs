using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : singleton<TimeManager>
{
    public float ptime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.ptime += Time.deltaTime;
    }
}
