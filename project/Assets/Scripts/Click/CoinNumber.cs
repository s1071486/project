﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinNumber : MonoBehaviour
{

    void Start()
    {

    }

    
    void Update()
    {
        GetComponent<Text>().text=SystemStorage.coin.ToString();
    }

    public void Click() 
    {
        SystemStorage.coin+=1;
    }

    public void Get100() //不想努力
    {
        SystemStorage.coin+=100;
    }
    
}
