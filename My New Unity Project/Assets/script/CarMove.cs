using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour {

    public int speed = 1;
    
    void Start()
    {
        MainScript mainScript = GameObject.Find("GameObject").GetComponent<MainScript>();
        speed = mainScript.speed; //MainScript 에서 랜덤으로 부여한 speed 값 넣기
    }

    void Update () {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); //움직이기

        if (this.transform.position.x > 16.0f || this.transform.position.x < -16.0f) //차 삭제조건
        Destroy(gameObject);
    }
}