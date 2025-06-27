using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterGenerator : MonoBehaviour
{
    public GameObject monster;
    public float span = 0.6f;
    public float level = 10.0f;
    public float delta = 0;
    public float ptime = 0;
    // Start is called before the first frame update
    void Update()
    {
        this.delta += Time.deltaTime;
        this.ptime += Time.deltaTime;

        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go1 = Instantiate(monster);
            GameObject go2 = Instantiate(monster);
            float px1 = Random.Range(-8.64f, -0.785f);
            float px2 = Random.Range(-0.785f, 7.07f);


            go1.transform.position = new Vector3(px1, 2.45f, 0);
            go2.transform.position = new Vector3(px2, 2.45f, 0);
        }
        if (Mathf.Abs(ptime - level) < 0.01f && level <= 80) // Mathf.Abs 결과 값을 절대값으로 가져옴, 오차 범위를 사용할 때 주로 사용
        {
            span -= 0.05f;
            this.level += 10.0f;
        }

    }
}
