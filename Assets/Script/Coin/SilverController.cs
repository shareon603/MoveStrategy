using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverController : MonoBehaviour
{
    public GameObject silver;
    public float delta;
    float coin = 3.1f;


    void Update()
    {
        this.delta += Time.deltaTime;
        if( this.delta > this.coin)
        {
            this.delta = 0;
            GameObject go = Instantiate(silver);
            float x = Random.Range(-8.64f, 7.22f);
            //go.transform.position = new Vector3(x, 2.46f, 0);
            go.transform.position = new Vector3(x, 2.46f, 0);
        }
    }
}
