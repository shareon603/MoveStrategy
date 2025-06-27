using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    GameObject mode, sgmode;
    void Start()
    {
        mode = GameObject.Find("Mode");
        sgmode = GameObject.Find("Single Mode");
        mode.SetActive(false);
        sgmode.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
