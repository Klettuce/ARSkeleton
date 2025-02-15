using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SliderHP : MonoBehaviour
{
    public float MaxHP = 30;
    public float currentHP;
    public Slider HPBar;

    void Start()
    {
        currentHP = MaxHP;
        HPBar.maxValue = MaxHP;// slider의 MaxValue를 우리가 원하는 체력 최대치로 초기화
        HPBar.value = currentHP;// slider의 value 값을 현재의 HP 값으로 초기화
    }

    void Update()
    {
        HPBar.value = currentHP;
        if (currentHP <= 0)
        {
            GameManager.instance.Onclear();
        }
    }

    public void damage(int n)
    {
        currentHP -= n;
    }

    public void ScoreUP(int n)
    {
        currentHP += n;
    }
}
