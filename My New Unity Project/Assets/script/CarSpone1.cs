using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpone1 : MonoBehaviour {

    public Transform carspone; //스폰위치 선언
    public GameObject car; //차 선언
    float delayTime = 3.5f; //딜레이 2초설정
    public int spone = 1; //차 생성 조건변수 선언

    void Start()
    {
        CarSpone2 carSpone2 = GameObject.Find("carspone2").GetComponent<CarSpone2>(); //carspone2에서 변수호출
        spone = carSpone2.spone; //carspone2의 spone 값을 여기로 옮기기
    }

    void Update()
    {
        if (delayTime <= 0 && spone == 1) //carspone2 가 차를 생성하지않으면 1이 생성
        {
            delayTime = 3.5f;
            Instantiate(car, carspone.position, carspone.rotation); //2초후 스폰위치에 차생성
        }
        delayTime -= Time.deltaTime;
    }
}
