using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    // Start is called before the first frame update
    public static Points instance;
    public int score = 0;
    public TextMeshProUGUI textscore;

    void Start()
    {
        instance = this;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textscore.text = score.ToString();

    }
}


