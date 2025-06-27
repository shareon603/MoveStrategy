using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startmonster : MonoBehaviour
{
    public GameObject monster;  
    float span = 2.0f;
    float delta = 0;
    int i = 0;
    Color randomcolor;
    Color blue = new Color(0, 0, 1, 1);
    Color green = new Color(0, 1, 0, 1);
    Color white = new Color(1, 1, 1, 1);
    // Start is called before the first frame update
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            if (i == 0)
            {
                randomcolor = white;
                i++;
            }
            else if (i == 1)
            {
                randomcolor = blue;
                i++;
            }
            else if (i == 2)
            {
                randomcolor = green;
                i = 0;
            }
            GameObject go = Instantiate(monster);
            
            go.transform.position = new Vector3(0, 4.8f, 0);
            go.transform.localScale = new Vector3(1.5f, 1.5f, 0);
            go.GetComponent<Renderer>().material.color = randomcolor;
        }
    }
}

