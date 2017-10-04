﻿using UnityEngine;

public class Bomb : MonoBehaviour {    
    public GameObject explosion;    

    // Use this for initialization
    void Start () {  
        Invoke("MakeExplosion",3f);
	}	

    void MakeExplosion()
    {
        Instantiate(explosion, new Vector3(this.transform.position.x, this.transform.position.y +0.8f, this.transform.position.z), this.transform.rotation);
        Destroy(this.gameObject);
    }
}
