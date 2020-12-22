using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class santa : MonoBehaviour
{
    //　プレイヤーの横幅、縦幅
    float width, height;
    float speed=GameInfo.INITIAL_SPEED;

    // Start is called before the first frame update
    void Awake()
    {
       width  = GetComponent<Renderer>().bounds.size.x;
       height = GetComponent<Renderer>().bounds.size.y; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //プレイヤーの右下の座標を取得する
    public Vector3 Get_UnderRightPosition(){

        Vector3 UnderRightPosition = transform.position; 
        UnderRightPosition -= new Vector3 (width/2, height/2,0);
        return UnderRightPosition; 
    }

    //プレイヤーの左上の座標を取得する
    public Vector3 Get_UpLeftPosition(){

        Vector3 UpLeftPosition = transform.position; 
        UpLeftPosition += new Vector3 (width/2, height/2,0);
        return UpLeftPosition; 
    }

    //　プレイヤーのスピードを取得する
    public float Get_PlayerSpeed(){
        return speed;
    }


}
