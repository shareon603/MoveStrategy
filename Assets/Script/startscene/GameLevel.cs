using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class GameLevel : MonoBehaviour
{
    public modeController LandmodeCtrol;
    public modeController IcemodeCtrol;
    public modeController LavamodeCtrol;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Easymode()
    {
        if(LandmodeCtrol.LandMap)
        {
            SceneManager.LoadScene("LandBattleScene");
            TimeManager.Instance.ptime = 0.0f;
        }

        else if (IcemodeCtrol.IceMap)
        {
            SceneManager.LoadScene("IceBattleScene");
            TimeManager.Instance.ptime = 0.0f;
        }

        else if (LavamodeCtrol.LavaMap)
        {
            SceneManager.LoadScene("LavaBattleScene");
            TimeManager.Instance.ptime = 0.0f;
        }
    }

    public void Normalmode()
    {
        if (LandmodeCtrol.LandMap)
        {
            SceneManager.LoadScene("LandBattleScene");
            TimeManager.Instance.ptime = 0.0f;
        }

        else if (IcemodeCtrol.IceMap)
        {
            SceneManager.LoadScene("IceBattleScene");
            TimeManager.Instance.ptime = 0.0f;
        }

        else if (LavamodeCtrol.LavaMap)
        {
            SceneManager.LoadScene("LavaBattleScene");
            TimeManager.Instance.ptime = 0.0f;
        }
    }

    public void Hardmode()
    {
        if (LandmodeCtrol.LandMap)
        {
            SceneManager.LoadScene("LandBattleScene");
            TimeManager.Instance.ptime = 0.0f;
        }

        else if (IcemodeCtrol.IceMap)
        {
            SceneManager.LoadScene("IceBattleScene");
            TimeManager.Instance.ptime = 0.0f;
        }

        else if (LavamodeCtrol.LavaMap)
        {
            SceneManager.LoadScene("LavaBattleScene");
            TimeManager.Instance.ptime = 0.0f;
        }
    }


    public void Battlemode()
    {
        SceneManager.LoadScene("GameScene");
        TimeManager.Instance.ptime = 0.0f;
    }
    public void Togethermode()
    {
        SceneManager.LoadScene("GameScene");
        TimeManager.Instance.ptime = 0.0f;
    }
}
