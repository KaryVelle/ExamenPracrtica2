using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour

{
    public GameObject gameoverpanel;
    // Start is called before the first frame update
    public static Points instance;
    public int score = 0;
    public TextMeshProUGUI textscore;

    void Start()
    {
        
        instance = this;
        score = 0;
        gameoverpanel = GameObject.FindWithTag("Panel");
        gameoverpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        textscore.text = score.ToString();

    }
    public void GameOver()
    {
        gameoverpanel.SetActive(true);
        MoveCat.instance.isgameover = true;
    }
}


