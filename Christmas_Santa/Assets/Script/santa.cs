using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class santa : MonoBehaviour
{
    //　プレイヤーの横幅、縦幅
    float width, height;
    float speed=GameInfo.INITIAL_SPEED;

    //プレイヤーの状態を管理する
    public enum PlayerState{
        NORMAL,
        JUMP,
        FALL
    }
    public PlayerState currentPlayerState;
    public Property HavePresent;

    // Start is called before the first frame update
    void Awake()
    {
       width  = GetComponent<Renderer>().bounds.size.x;
       height = GetComponent<Renderer>().bounds.size.y; 
       SetCurrentPlayerState (PlayerState.NORMAL);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(currentPlayerState);
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

    // 衝突判定まわり
    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("Enter");

            if (col.gameObject.tag == "roof")
            {
                SetCurrentPlayerState(PlayerState.NORMAL);
            }
    }
    
    
    void OnCollisionExit2D(Collision2D col)
    {
        //Debug.Log("Exit");
            if (col.gameObject.tag == "roof")
            {
                SetCurrentPlayerState(PlayerState.JUMP);
            }
    }
    
    void OnTriggerEnter2D(Collider2D col){

        if(col.gameObject.tag == "red"    ||
           col.gameObject.tag == "yellow" ||
           col.gameObject.tag == "blue"   ){
            
            col.gameObject.SetActive(false);
            HavePresent.SetHavePresent(col.gameObject.GetComponent<present>().GetPresentType());
            //StartCoroutine ("PresentMoveAnimation");
        }

    }
    

    // プレイヤーの状態を変える
    public void ChangeCurrentPlayerState () {
        switch (currentPlayerState) {
            case PlayerState.NORMAL:
                currentPlayerState = PlayerState.JUMP;
                break;
            case PlayerState.JUMP:
                break;
        }
    }

     // ゲームの状態をセットする
    public void SetCurrentPlayerState (PlayerState state) {
        currentPlayerState = state;
    }


    //playerが地面に着いているかどうか判定
    public bool LandRoof(){
        if(currentPlayerState == PlayerState.NORMAL){
            return true;
        }
        else{
            return false;
        }
    }
    
}
