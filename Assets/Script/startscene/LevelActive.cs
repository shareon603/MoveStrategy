using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelActive : MonoBehaviour
{
    GameObject level;
    // Start is called before the first frame update
    void Start()
    {
        level = GameObject.Find("Level");
        if (level == null)
        {
            Debug.Log("sda");
        }
        level.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
