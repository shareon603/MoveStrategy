using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randommonster : MonoBehaviour
{
    public GameObject monster;
    float span = 3.6f;
    float level = 10.0f;
    float delta = 0;
    float ptime = 0;
    // Start is called before the first frame update
    void Update()
    {
        this.delta += Time.deltaTime;
        this.ptime += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(monster);
            Color blue = new Color(0, 0, 1, 1);
            Color green = new Color(0, 1, 0, 1);
            Color color = (Random.value > 0.5f) ? blue :green;
            float px1 = Random.Range(-8.64f, 7.07f);
            go.transform.position = new Vector3(px1, 2.45f, 0);
            go.GetComponent<Renderer>().material.color = color;
        }
        if (Mathf.Abs(ptime - level) < 0.01f && level <= 80) // Mathf.Abs 결과 값을 절대값으로 가져옴, 오차 범위를 사용할 때 주로 사용
        {
            span -= 0.05f;
            this.level += 10.0f;
        }

    }
}
