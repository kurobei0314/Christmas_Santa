using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        StartCoroutine ("ResultAnimation");   
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

    private IEnumerator ResultAnimation() {
        
        yield return new WaitForSeconds (1.0f);

        Sprite sprite = Resources.Load<Sprite>("Image/OpenPresent_R");
        Present_R.GetComponent<Image>().sprite = sprite;
        
        for (int i = 0 ; i < 3; i++){
            yield return new WaitForSeconds (1.0f);
            mokumoku[i].SetActive(true);
        }

        text.SetActive(true);
        button.SetActive(true);

    }
}
