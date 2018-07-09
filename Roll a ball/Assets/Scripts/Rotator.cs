using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
	public float MoveSpeed;
	// Update is called once per frame
    private int count;
    void Start(){
        count = 0;
    }
	void Update () {
        count++;
		transform.Rotate (new Vector3(15, 30, 45) * Time.deltaTime);
        if(count/100%2==0)
            transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime, Space.World);
        else
            transform.Translate(Vector3.back * MoveSpeed * Time.deltaTime, Space.World);
	}
}
