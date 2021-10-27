using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonControl : MonoBehaviour
{
    //public Vector3 SpawnBoll = new Vector3(-0.2f,2.2f,0f);
    public GameObject Ammunation;
    public GameObject Spawn;
    public float Cooldown = 3f;
    //public float timefire = 0;
    public bool isShoot = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isShoot)
        {
            isShoot = true;
            Instantiate(Ammunation, Spawn, Ammunation.transform.rotation);
        }

        if(isShoot)
        {
            isShoot = false;
            Invoke("cooldown",Cooldown);
        }

         
    }

    private void Instantiate(GameObject Ammunation, GameObject Spawn, Quaternion rotation)
    {
        throw new NotImplementedException();
    }

    private void cooldown()
    {
        isShoot = true;
    }
}
