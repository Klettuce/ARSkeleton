using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public Transform[] posc;
    public GameObject[] prefabc;
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        StartCoroutine(UpCoin());
    }

    IEnumerator UpCoin()
    {
        while (true)
        {
            float waitTime = Random.Range(2.0f, 4.0f);
            yield return new WaitForSeconds(waitTime);// 몇초있다가 실행해라

            for (int i = 0; i < 2; i++)// 코인 2개
            {
                int iPrefabc = Random.Range(0, prefabc.Length);// 종류
                int iPosc = Random.Range(0, posc.Length);// 위치값

                GameObject objc = Instantiate(prefabc[iPrefabc], posc[iPosc].position, Quaternion.identity);// 프리팹을 새로만드는 위치랑 회전

                Destroy(objc, 5f);

                Rigidbody rb = objc.GetComponent<Rigidbody>();

                rb.AddForce(Vector3.up * Random.Range(4.0f, 10.0f), ForceMode.VelocityChange);
            }
            audio.Play();
        }
    }
}
