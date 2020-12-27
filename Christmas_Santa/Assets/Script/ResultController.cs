using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultController : MonoBehaviour
{
    public GameObject Present_R;
    public GameObject[] mokumoku;
    public GameObject text;
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        InitializeActive();
        InitializeText();
        StartCoroutine ("ResultAnimation");  
        InitializeButton();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitializeActive(){
        Present_R.SetActive(true);
        text.SetActive(false);
        button.SetActive(false);

        for (int i=0 ; i < 3 ;i++){
            mokumoku[i].SetActive(false);
        }
    }

    void InitializeButton(){
        GameObject TitleButton = button.transform.Find("title").gameObject;
        GameObject RankingButton= button.transform.Find("ranking").gameObject;
        
        TitleButton.GetComponent<Button>().onClick.AddListener (TitleClick);
        RankingButton.GetComponent<Button>().onClick.AddListener (RankingClick);
    }

    void InitializeText(){

        GameObject ScoreText = text.transform.Find("score").gameObject;
        GameObject AllScoreText = text.transform.Find("allscore").gameObject;

        int distance = ScoreManager.instance.score - 100 * ScoreManager.instance.GetPresent;
        string TextContext = "100 × "+ ScoreManager.instance.GetPresent + " + " + distance;

        ScoreText.GetComponent<Text>().text = TextContext;
        AllScoreText.GetComponent<Text>().text = ScoreManager.instance.score + "てん";

    }


    private IEnumerator ResultAnimation() {
        
        yield return new WaitForSeconds (0.5f);

        Sprite sprite = Resources.Load<Sprite>("Image/OpenPresent_R");
        Present_R.GetComponent<Image>().sprite = sprite;
        
        for (int i = 0 ; i < 3; i++){
            yield return new WaitForSeconds (1.0f);
            mokumoku[i].SetActive(true);
        }

        text.SetActive(true);
        button.SetActive(true);

    }

    public void TitleClick(){

        Debug.Log("title");
    }

    public void RankingClick(){
        Debug.Log("ranking");
    }
}
