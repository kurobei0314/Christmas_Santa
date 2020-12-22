using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject player;
    public GameObject touchpanel;
    [SerializeField] private Camera camera;


     //ゲームの状況を管理する
    public enum GameState{
        COUNT,
        MAIN,
        GAMEOVER
    }

    public GameState currentGameState;

    // Start is called before the first frame update
    void Start()
    {
        touchpanel.GetComponent<Button>().onClick.AddListener (Click_touchpanel);
    }

    // Update is called once per frame
    void Update()
    {
        //if(currentGameState == GameState.MAIN){
            player.transform.position -= new Vector3(0.0f, GameInfo.GRAVITY,0.0f);

            //　プレイヤーが下にいるかどうかを確認する
            Vector3 PlayerUpLeftPosition = player.GetComponent<santa>().Get_UpLeftPosition();
            if(camera.transform.position.y - 7.5f > PlayerUpLeftPosition.y){
                Debug.Log("wa-i");
                // currentGameState = GameInfo.GAMEOVER;
            }
        //}
    
    }

    //画面をクリックした時の処理
    void Click_touchpanel(){
        player.transform.position += new Vector3 (0.0f,GameInfo.PLAYER_JUMP,0.0f);
    }
}
