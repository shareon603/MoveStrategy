using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class stopbtn : MonoBehaviour
{
    GameObject stopping;
    GameObject btnL, btnR;
    EventTrigger Ltrigger, Rtrigger;
    //public GameObject canvas = null;
    //public bool state = false;

    
    // Start is called before the first frame update
    void Start()
    {
        stopping = GameObject.Find("Stopping");
        //stopping = GameObject.Find("Canvas").transform.GetChild(6).transform.gameObject;
        //canvas = GameObject.Find("Canvas").gameObject;
        //stopping.SetActive(false);
        //shopping.SetActive(false);
        btnL = GameObject.Find("LButton");
        btnR = GameObject.Find("RButton");
        Ltrigger = btnL.GetComponent<EventTrigger>();
        Rtrigger = btnR.GetComponent<EventTrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        //stopping.SetActive(state);
        //shopping.SetActive(state);
    }
    public void Btnstart()//일시정지
    {
        //canvas.transform.GetChild(6).transform.gameObject.SetActive(true);
        stopping.SetActive(true);
        //state = true;
        Ltrigger.enabled = false;
        Rtrigger.enabled = false;
        Time.timeScale = 0;
       
    }
    public void Startbtn()//게임시작
    {
        stopping.SetActive(false);
        Ltrigger.enabled = true;
        Rtrigger.enabled = true;
        Time.timeScale = 1;
    }
    public void Restart()//재시작
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        TimeManager.Instance.ptime = 0.0f;
    }
    public void Homebtn()//메인화면
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("HomeScene");
    }

    public void Exitbtn()
    {
        Application.Quit();
    }

}
