using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public float monspeed = -0.001f;
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
            transform.Translate(monspeed, 0, 0);

            if (transform.position.y < -2.78)
            {
                Destroy(gameObject);
            }

        }
        else if (statePanel.activeSelf)
        {
            transform.Translate(0, 0, 0);
        }
    }
}
