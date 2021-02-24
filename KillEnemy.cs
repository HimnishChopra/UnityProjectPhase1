using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void onTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="e")
        {
            Destroy(other.gameObject);
        }
    }
}
