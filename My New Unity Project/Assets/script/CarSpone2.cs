using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpone2 : MonoBehaviour {

    public Transform carspone2; //스폰위치 선언
    public GameObject car; //차 선언
    float delayTime = 3.5f; //딜레이 2초설정
    public int spone = 0; //차 생성 조건변수 선언

    void Start()
    {
        spone = Random.Range(0, 2); // 0과 1중 랜덤값 생성
    }

    void Update()
    {
        if (delayTime <= 0 && spone == 0) //spone 값이 0이면 carspone2가 차 생성
        {
            delayTime = 3.5f;
            Instantiate(car, carspone2.position, carspone2.rotation); //2초후 스폰위치에 차생성
        }
        delayTime -= Time.deltaTime;
    }
}
