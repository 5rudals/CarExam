using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour {
    public int speed = 1;

    void Start()
    {
        speed = Random.Range(1, 6); //랜덤으로 speed값 지정
    }
    void Update () {

	}
}
