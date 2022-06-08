using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{

    public float tmax = 3;
    public float tinicial = 0;
    public GameObject obst;
    public float altura= 4f;
    



    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

       // Debug.Log(tinicial);
        if (tinicial>=tmax)
        {
            GameObject nuevoobst = Instantiate(obst);
            nuevoobst.transform.position = new Vector3(9, 0, 0);
            nuevoobst.transform.position =  new Vector3(9, Random.Range(-altura, altura), 0);
            

            //Debug.Log("INSTANCIA CADA 3");
            tinicial = 0;
        }
        else
        {
            
            tinicial += Time.deltaTime;
            
        }
    }
}
