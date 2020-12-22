using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property : MonoBehaviour
{
    //[SerializeField] SpriteRenderer[] HavePresent;
    public PropertyPresent[] HavePresent;

    // Start is called before the first frame update
    void Start()
    {
        HavePresentInitialize(); 
    }

    // Update is called once per frame
    void Update()
    {
    
    }


    //持っているプレゼントの初期化
    /*
    void HavePresentInitialize(){

        HavePresent = new GameObject[3];

        for(int i=0; i<3; i++){
            HavePresent[i] =  PropertyPresent[i];
        }
        
    }
    */
    void HavePresentInitialize(){

        for(int i=0; i < GameInfo.MAX_HAVEPRESENT; i++){

            HavePresent[i].SetPresentType(PresentInfo.Type.NONE);
            //HavePresent[i].GetComponent<PropertyPresent>().SetPresentType(PresentInfo.Type.NONE);
        }
    } 

    public void SetHavePresent(PresentInfo.Type type){

        for(int i=0; i < GameInfo.MAX_HAVEPRESENT; i++){

            if(HavePresent[i].GetPresentType() == PresentInfo.Type.NONE){
                HavePresent[i].SetPresentType(type);
                break;
            }
        }
    }

}
