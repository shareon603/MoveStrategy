using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldController : MonoBehaviour
{
    public GameObject gold;
    public float delta;
    float coin = 5.3f;

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.coin)
        {
            this.delta = 0;
            GameObject go = Instantiate(gold);
            float x = Random.Range(-8.64f, 7.22f);
            //go.transform.position = new Vector3(x, 2.46f, 0);
            go.transform.position = new Vector3(x, 2.46f, 0);
        }
    }
}
