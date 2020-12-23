using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wantperson : MonoBehaviour
{
    PresentInfo.Type currentWantPresentType;

    // Start is called before the first frame update
    void Start()
    {
        InitializeType();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void InitializeType(){

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
    }
    public PresentInfo.Type GetWantPresentType(){

        return currentWantPresentType;
    }
}
