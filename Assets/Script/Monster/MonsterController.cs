using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public float monspeed;
    public float level;
    public float montime;
    GameObject statePanel;
    // Start is called before the first frame update
    void Start()
    {
        monspeed = 0.001f;
        level = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        montime = TimeManager.Instance.ptime;
        statePanel = GameObject.Find("Stopping");

        if (statePanel == null)
        {
            transform.Translate(monspeed, 0, 0);

            if (transform.position.y < -2.78)
            {
                Destroy(gameObject);
            }
            if (montime >= level && level <= 80)
            {
                monspeed += 0.0005f;
                this.level += 10.0f;
            }

        }
        else if (statePanel.activeSelf)
        {
            transform.Translate(0, 0, 0);
        }
    }
}
