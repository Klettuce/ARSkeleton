using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk : MonoBehaviour
{
    public GameObject T1;
    public GameObject T2;
    public GameObject T3;
    public GameObject T4;
    public GameObject T5;

    public void OpenT2()
    {
        T2.SetActive(true);
        T1.SetActive(false);
    }
    public void OpenT3()
    {
        T3.SetActive(true);
        T2.SetActive(false);
    }
    public void OpenT4()
    {
        T4.SetActive(true);
        T3.SetActive(false);
    }
    public void OpenT5()
    {
        T5.SetActive(true);
        T4.SetActive(false);
    }
}
