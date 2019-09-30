﻿using UnityEngine;
using System.Collections;

public class RotationScript : MonoBehaviour {

    public int speed = 1;	
	
	void Update () {
        
        transform.Rotate (Vector3.up * speed * Time.deltaTime);
	}
}
