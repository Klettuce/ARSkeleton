using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject camera;
    public GameObject prefab;
    public GameObject HPbarUI;
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void Fire()
    {
        RaycastHit hit;// Raycast : 직선으로 광선을 쏜다, 직선을 보는 함수
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit))
        {
            if (hit.transform.tag == "Enermy")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(prefab, hit.point, Quaternion.LookRotation(hit.normal));

                audio.Play();

                HPbarUI = GameObject.Find("Slider");
                HPbarUI.GetComponent<SliderHP>().damage(5);
            }

            if (hit.transform.tag == "ScoreCoin")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(prefab, hit.point, Quaternion.LookRotation(hit.normal));

                audio.Play();

                HPbarUI = GameObject.Find("Slider");
                HPbarUI.GetComponent<SliderHP>().ScoreUP(3);
            }
        }
    }
}
