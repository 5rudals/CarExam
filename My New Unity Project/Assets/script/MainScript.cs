using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour {

    public int speed = 1;

    void Start()
    {
        speed = Random.Range(3, 6); //랜덤으로 3 ~ 6speed값 지정
    }
}
