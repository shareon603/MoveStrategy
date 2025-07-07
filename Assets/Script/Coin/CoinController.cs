using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public float level;
    public float monspeed;
    public float cointime;
    GameObject statePanel;
    // Start is called before the first frame update
    void Start()
    {
        level = 10.0f;
        monspeed = -0.001f;
    }

    // Update is called once per frame
    void Update()
    {
        cointime = TimeManager.Instance.ptime;
        statePanel = GameObject.Find("Stopping");
        if (statePanel == null)
        {
            transform.Translate(0, monspeed, 0);

            if (transform.position.y < -2.78)
            {
                Destroy(gameObject);
            }
            if (cointime >= level && level <= 80)
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
