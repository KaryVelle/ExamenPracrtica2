using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{

    public float tmaxenemy = 3;
    public float tmaxpoints = 5;
    public float tinicialenemy = 0;
    public float tinicialpoints = 0;
    public GameObject points;
    public GameObject enemy;
    public float altura= 4f;
    private float currentscore;

    public Points pointsController;
    



    // Start is called before the first frame update
    void Start()
    {

        
        

    }

    // Update is called once per frame
    void Update()
    {
        currentscore = pointsController.score;

        if (currentscore>=5)
        {
            tmaxenemy = 3;

         
        }
        if (currentscore >= 7)
        {
            tmaxenemy = 1;


        }

        // Spawner Enemies
        if (tinicialenemy >= tmaxenemy)
        {
            GameObject nuevoobst = Instantiate(enemy);
            nuevoobst.transform.position = new Vector3(this.transform.position.x, 0, 0);
            nuevoobst.transform.position = new Vector3(this.transform.position.x, Random.Range(-altura, altura), 0);


            //Debug.Log("INSTANCIA CADA 3");
            tinicialenemy = 0;
        }
        else
        {

            tinicialenemy += Time.deltaTime;

        }

        // Spawner Points
        if (tinicialpoints>=tmaxpoints)
        {
            GameObject nuevoobst = Instantiate(points);
            nuevoobst.transform.position = new Vector3(this.transform.position.x, 0, 0);
            nuevoobst.transform.position =  new Vector3(this.transform.position.x, Random.Range(-altura, altura), 0);
            

            //Debug.Log("INSTANCIA CADA 3");
            tinicialpoints = 0;
        }
        else
        {
            
            tinicialpoints += Time.deltaTime;
            
        }
    }
}
