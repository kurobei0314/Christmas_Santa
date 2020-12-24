﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    //アイテムの種類を管理する
    public enum ItemTypes{
        NONENA,
        COLA,
        GREENTEA
    }

    [SerializeField] ItemTypes ItemType;

    // Start is called before the first frame update
    void Start()
    {
        InitializeType();
        ItemType = ItemTypes.COLA;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //後で考える
    void InitializeType(){

        /*
        switch(this.gameObject.tag){
            case "W_red":
                currentWantPresentType = PresentInfo.Type.RED;
                break;
            case "W_yellow":
                currentWantPresentType = PresentInfo.Type.YELLOW;
                break;
            case "W_blue":
                currentWantPresentType = PresentInfo.Type.BLUE;
                break;
        }
        */
    }

    public float ChangeSantaSpeedAmount(){

        switch(ItemType){
            case ItemTypes.NONENA:
                return GameInfo.COLA_SPEED;
            case ItemTypes.COLA:
                return GameInfo.COLA_SPEED;
            case ItemTypes.GREENTEA:
                return GameInfo.GREENTEA_SPEED;
        }  
        return 0.0f;      

    }
}
