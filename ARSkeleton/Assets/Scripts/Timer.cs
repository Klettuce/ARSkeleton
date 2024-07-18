using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerTxt;
    public float time = 30f;
    private float Countdown;
    private bool isDead=false;

    void Start()
    {
        Countdown = time;
    }

    void Update()
    {
        if(Countdown <= 0){
            // 타이머가 0이하가 되면 게임오버시키기
            isDead = true;
            GameManager.instance.OnPlayerDead();
        }
        else
        {
            Countdown -= Time.deltaTime;
            timerTxt.text = "지구 침공까지 : " + ((int)Countdown).ToString() + "초";
        }
    }
}