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
        HPBar.maxValue = MaxHP;// slider�� MaxValue�� �츮�� ���ϴ� ü�� �ִ�ġ�� �ʱ�ȭ
        HPBar.value = currentHP;// slider�� value ���� ������ HP ������ �ʱ�ȭ
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
