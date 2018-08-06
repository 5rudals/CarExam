using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpone1 : MonoBehaviour {

    public Transform carspone1;
    public GameObject car;
    float delayTime = 2; //딜레이 2초설정
    void Update()
    {
        if (delayTime <= 0)
        {
            delayTime = 2;
            Instantiate(car, carspone1.position, carspone1.rotation); //2초후 스폰위치에 차생성
        }
        delayTime -= Time.deltaTime;
    }
}
