using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class GameInfo{

    //プレイヤーのジャンプ力
    public static readonly float PLAYER_JUMP = 2.0f;

    //プレイヤーの重力
    public static readonly float GRAVITY = -0.3f;   

    //プレイヤーの初期速度
    public static readonly float INITIAL_SPEED = 0.1f;
    
}

public static class PresentInfo{
    public enum Type{
        RED,
        BLUE,
        YELLOW,
        NONE
    }
    public static Type PresentType;
}
