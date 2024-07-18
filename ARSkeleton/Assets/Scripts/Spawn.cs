using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] pos;
    public GameObject[] prefab;

    AudioSource audio;

    public float speed = -0.01f;
    private Vector3 originScale;

    private void Awake()
    {
        originScale = transform.localScale;
    }

    void Start()
    {
        audio = GetComponent<AudioSource>();

        StartCoroutine(WaitAndSpawn());//���ÿ� ���ư����ϴ�
    }

    IEnumerator WaitAndSpawn()
    {
        
        while (true)
        {
            float waitTime = Random.Range(2.0f, 4.0f);
            yield return new WaitForSeconds(waitTime);// �����ִٰ� �����ض�

            for (int i = 0; i < 3; i++)// �ذ�3��
            {
                int iPrefab = Random.Range(0, prefab.Length);// �ذ�����
                int iPos = Random.Range(0, pos.Length);// ��ġ��

                GameObject obj = Instantiate(prefab[iPrefab], pos[iPos].position, Quaternion.Euler(0,180,0));// �������� ���θ���� ��ġ�� ȸ��

                Destroy(obj, 5f);

                Rigidbody rb = obj.GetComponent<Rigidbody>();

                transform.Translate(0, 0, speed * Time.deltaTime);
                speed += 0.01f;
            }
            audio.Play();
        }
    }
}
