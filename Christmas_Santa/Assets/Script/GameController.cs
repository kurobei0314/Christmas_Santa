using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject player;
    public GameObject touchpanel;

    // Start is called before the first frame update
    void Start()
    {
        touchpanel.GetComponent<Button>().onClick.AddListener (Click_touchpanel);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Click_touchpanel(){

        player.transform.position += new Vector3 (0.0f,2.0f,0.0f);
    }
}
