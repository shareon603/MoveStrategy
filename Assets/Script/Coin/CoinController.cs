using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    float level = 10.0f;
    float monspeed = -0.001f;
    GameObject statePanel;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        statePanel = GameObject.Find("Stopping");
        if (statePanel == null)
        {
            transform.Translate(0, monspeed, 0);

            if (transform.position.y < -2.78)
            {
                Destroy(gameObject);
            }
            if (Time.time >= level)
            {
                monspeed -= 0.0005f;
                this.level += 10.0f;
            }
        }
        else if (statePanel.activeSelf)
        {
            transform.Translate(0, 0, 0);
        }
        
    }
}
