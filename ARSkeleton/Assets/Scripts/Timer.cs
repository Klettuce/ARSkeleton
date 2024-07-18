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
            // Ÿ�̸Ӱ� 0���ϰ� �Ǹ� ���ӿ�����Ű��
            isDead = true;
            GameManager.instance.OnPlayerDead();
        }
        else
        {
            Countdown -= Time.deltaTime;
            timerTxt.text = "���� ħ������ : " + ((int)Countdown).ToString() + "��";
        }
    }
}