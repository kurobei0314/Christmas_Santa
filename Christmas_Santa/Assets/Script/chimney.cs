using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chimney : MonoBehaviour
{

    [SerializeField] PresentInfo.Type currentChimneyPresentType;
    [SerializeField] private GameObject WantPresentImageSprite;

    //煙突の状態を管理する
    public enum ChimneyState{
        WANT,
        GET
    }
    public ChimneyState currentChimneyState;    

    // Start is called before the first frame update
    void Start()
    {
        WantPresentImageSprite.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitializeType(){

        string ImagePass = "";

        switch(currentChimneyPresentType){
            case PresentInfo.Type.RED:
                ImagePass = "Pictures/HavePresent_R";
               
                break;
            case PresentInfo.Type.YELLOW:
                ImagePass = "Pictures/HavePresent_Y";
                break;
            case PresentInfo.Type.BLUE:
                ImagePass = "Pictures/HavePresent_B";
                break;
        }
    }

    public bool JudgePresentAccept(){

        if      (currentChimneyState == ChimneyState.WANT){
            return true;
        }
        else if (currentChimneyState == ChimneyState.GET){
            return false;
        }

        return false;
    }

    public void WantPresentActive(){
        WantPresentImageSprite.SetActive(false);
    }

    public PresentInfo.Type GetPresentType(){
        return currentChimneyPresentType;
    }
    public void ChangeImage(string pass){

        Sprite sprite = Resources.Load<Sprite>(pass);
        WantPresentImageSprite.GetComponent<SpriteRenderer>().sprite = sprite;
    }
}
