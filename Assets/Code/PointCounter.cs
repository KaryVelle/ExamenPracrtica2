using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PointCounter : MonoBehaviour
{
   

    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    private void OnTriggerEnter2D(Collider2D otherobject)
    {
        if (otherobject.CompareTag("Player") && this.gameObject.tag != "Enemy")
        {
            Points.instance.score++;
            Destroy(this.gameObject);
        }
       

        if (otherobject.CompareTag("Player") && this.gameObject.tag== "Enemy")
        {
            Points.instance.GameOver();
            Destroy(this.gameObject);
            
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
