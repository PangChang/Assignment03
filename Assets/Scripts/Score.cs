using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int MaxPinCount = 0;
    public static int PinCount = 0;
    public Text score;
    public Text MaxScore;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);   
    }

    void Start()
    {
        PinCount = 0;
        MaxScore.text = MaxPinCount.ToString();
    }

    void Update()
    {
        score.text = PinCount.ToString();
        if (MaxPinCount < PinCount)
        {
            MaxPinCount = PinCount;
            Debug.Log(MaxPinCount);
        }
        MaxScore.text = MaxPinCount.ToString();

    }

}
