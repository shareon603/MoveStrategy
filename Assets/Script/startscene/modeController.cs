using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;

public class modeController : MonoBehaviour
{
    public GameObject mode, sgmode, Land, Ice, Lava, option;
    public bool LandMap, IceMap, LavaMap;
    public modeController LandmodeCtrol;
    public modeController IcemodeCtrol;
    public modeController LavamodeCtrol;
    // Start is called before the first frame update
    void Start()
    {
        LandmodeCtrol = GameObject.Find("Land").GetComponent<modeController>();
        IcemodeCtrol = GameObject.Find("Ice").GetComponent<modeController>();
        LavamodeCtrol = GameObject.Find("Lava").GetComponent<modeController>();
        LandMap = false;
        IceMap = false;
        LavaMap = false;
        //mode = GameObject.Find("Mode");
        //sgmode = GameObject.Find("SingleMode");
        //mode.SetActive(false);
        //sgmode.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartMode()
    {
        mode.SetActive(true);
    }
    public void modeEnd()
    {
        mode.SetActive(false);
    }

    public void StartOption()
    {
        option.SetActive(true);
    }

    public void StartsgMode()
    {
        sgmode.SetActive(true);
    }

    public void sgmodeEnd()
    {
        sgmode.SetActive(false);
        LandmodeCtrol.LandMap = false;
        IcemodeCtrol.IceMap = false;
        LavamodeCtrol.LavaMap = false;
    }

    public void LandLevelStart()
    {
        LandMap = true;
        IceMap = false;
        LavaMap = false;
        Land.SetActive(true);
    }

    public void IceLevelStart()
    {
        IceMap = true;
        LandMap = false;
        LavaMap = false;
        Ice.SetActive(true);
    }

    public void LavaLevelStart()
    {
        LavaMap = true;
        LandMap = false;
        IceMap = false;
        Lava.SetActive(true);
    }

}
