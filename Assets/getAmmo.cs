using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getAmmo : MonoBehaviour

    
{
    float ammoCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collider other)
    {
    
       Destroy(this.gameObject);
        ammoCount = 20;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
