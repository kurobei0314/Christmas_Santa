using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject player;
    public GameObject touchpanel;
    [SerializeField] Camera camera;

    Rigidbody2D rigidbody;
    GameObject[] HavePresent;

    [SerializeField] GameObject[] PropertyPresent;   

    //プレイヤーの状態を管理する
    public enum GameState{
        COUNTDOWN,
        MAIN,
        GAMEOVER
    }

    public GameState currentGameState;

    // Start is called before the first frame update
    void Start()
    {
        touchpanel.GetComponent<Button>().onClick.AddListener (Click_touchpanel);
        SetCurrentGameState(GameState.MAIN);

    }

    // Update is called once per frame
    void Update()
    {
        if     (currentGameState == GameState.COUNTDOWN){

        }
        else if(currentGameState == GameState.MAIN){
            
            PlayerControll();

        }

        else if(currentGameState == GameState.GAMEOVER){

        }
        
    
    }

    //持っているプレゼントの初期化
    void HavePresentInitialize(){

        HavePresent = new GameObject[3];

        for(int i=0; i<3; i++){
            HavePresent[i] =  PropertyPresent[i];
        }
        
    }

    //　プレイヤーの移動
    public void PlayerControll(){

        float PlayerSpeed = player.GetComponent<santa>().Get_PlayerSpeed();
            
        rigidbody = player.GetComponent<Rigidbody2D>();
        rigidbody.MovePosition( player.transform.position + new Vector3(PlayerSpeed, GameInfo.GRAVITY,0.0f) );

        //　プレイヤーが下にいるかどうかを確認する
        Vector3 PlayerUpLeftPosition = player.GetComponent<santa>().Get_UpLeftPosition();
        
        if(camera.transform.position.y - 7.5f > PlayerUpLeftPosition.y){
            // SetCurrentGameState(GameState.GAMEOVER);
        }
    }
    

    // ゲームの状態をセットする
    public void SetCurrentGameState (GameState state) {
        currentGameState = state;
    }

    //画面をクリックした時の処理
    void Click_touchpanel(){

        if(player.GetComponent<santa>().LandRoof()){
            rigidbody = player.GetComponent<Rigidbody2D>();
            rigidbody.AddForce(Vector2.up * GameInfo.PLAYER_JUMP);
        }
    }

}
