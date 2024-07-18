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
            yield return new WaitForSeconds(waitTime);// �����ִٰ� �����ض�

            for (int i = 0; i < 2; i++)// ���� 2��
            {
                int iPrefabc = Random.Range(0, prefabc.Length);// ����
                int iPosc = Random.Range(0, posc.Length);// ��ġ��

                GameObject objc = Instantiate(prefabc[iPrefabc], posc[iPosc].position, Quaternion.identity);// �������� ���θ���� ��ġ�� ȸ��

                Destroy(objc, 5f);

                Rigidbody rb = objc.GetComponent<Rigidbody>();

                rb.AddForce(Vector3.up * Random.Range(4.0f, 10.0f), ForceMode.VelocityChange);
            }
            audio.Play();
        }
    }
}
