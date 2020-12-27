using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TitleController : MonoBehaviour
{

    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        InitializeButton();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitializeButton(){
        GameObject StartButton = button.transform.Find("GameStart").gameObject;
        GameObject TutolialButton= button.transform.Find("Tutolial").gameObject;
        
        StartButton.GetComponent<Button>().onClick.AddListener (StartClick);
        TutolialButton.GetComponent<Button>().onClick.AddListener (TutolialClick);
    }

    void StartClick(){
        SceneManager.LoadScene("Main");
    }

    void TutolialClick(){
        Debug.Log("tutorial");
    }

}
