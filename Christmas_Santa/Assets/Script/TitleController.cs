using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;


public class TitleController : MonoBehaviour
{

    public GameObject Santa;
    public GameObject button;
    public GameObject EndPosition;
    public GameObject Text;

    // Start is called before the first frame update
    void Start()
    {
        InitializeActive();
        StartCoroutine ("TitleAnimation");
        InitializeButton();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitializeActive(){

        button.SetActive(false);

        Text Text1 = Text.transform.Find("Text1").gameObject.GetComponent<Text>();
        Text Text2 = Text.transform.Find("Text2").gameObject.GetComponent<Text>();
        Text1.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        Text2.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
    }


    void InitializeButton(){
        GameObject StartButton = button.transform.Find("GameStart").gameObject;
        GameObject TutolialButton= button.transform.Find("Tutolial").gameObject;
        
        StartButton.GetComponent<Button>().onClick.AddListener (StartClick);
        TutolialButton.GetComponent<Button>().onClick.AddListener (TutolialClick);
    }

    void StartClick(){
        FadeManager.Instance.LoadScene ("Main", 1.0f);
    }

    void TutolialClick(){
        Debug.Log("tutorial");
    }

    private IEnumerator TitleAnimation() {

        Santa.transform.DOMove (
            EndPosition.transform.position,　　//移動後の座標
            1.0f 　　　　　　    //時間
        );
        yield return new WaitForSeconds (1.0f);

        Text Text1 = Text.transform.Find("Text1").gameObject.GetComponent<Text>();
        Text Text2 = Text.transform.Find("Text2").gameObject.GetComponent<Text>();

        DOTween.ToAlpha(
            () => Text1.color, 
            color => Text1.color = color,
            1.0f,                                
            1.0f
        );

        DOTween.ToAlpha(
            () => Text2.color, 
            color => Text2.color = color,
            1.0f,                                
            1.0f
        );

        yield return new WaitForSeconds (1.0f);
        button.SetActive(true);
    }

}
