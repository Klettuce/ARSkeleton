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

        StartCoroutine(WaitAndSpawn());//동시에 돌아가게하는
    }

    IEnumerator WaitAndSpawn()
    {
        
        while (true)
        {
            float waitTime = Random.Range(2.0f, 4.0f);
            yield return new WaitForSeconds(waitTime);// 몇초있다가 실행해라

            for (int i = 0; i < 3; i++)// 해골3개
            {
                int iPrefab = Random.Range(0, prefab.Length);// 해골종류
                int iPos = Random.Range(0, pos.Length);// 위치값

                GameObject obj = Instantiate(prefab[iPrefab], pos[iPos].position, Quaternion.Euler(0,180,0));// 프리팹을 새로만드는 위치랑 회전

                Destroy(obj, 5f);

                Rigidbody rb = obj.GetComponent<Rigidbody>();

                transform.Translate(0, 0, speed * Time.deltaTime);
                speed += 0.01f;
            }
            audio.Play();
        }
    }
}
