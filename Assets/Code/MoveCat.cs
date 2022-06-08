using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCat : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isgameover;
    Rigidbody2D sans;
    public float maxspeed;
    bool volteaderecha = true;
    SpriteRenderer sansvoltea;
    public static MoveCat instance;

    // saltar 

    bool puedoaccion = true;
    bool suelo = false;
    float revisarsuelo = 0.2f;
    public LayerMask capasuelo;
    public Transform checarsuelo;
    public float quetantosaltas;

    void Start()
    {
        instance = this;
        isgameover = false;
        sans = GetComponent<Rigidbody2D>();
        sansvoltea = GetComponent<SpriteRenderer>(); // funcion voltear
    }

    // Update is called once per frame
    void Update()
    {
        if ((puedoaccion && suelo && Input.GetAxis("Jump") > 0)&&(isgameover==false))
        {
            sans.velocity = new Vector2(sans.velocity.x, 0f);
            sans.AddForce(new Vector2(0, quetantosaltas), ForceMode2D.Impulse);
            suelo = false;
        }


        suelo = Physics2D.OverlapCircle(checarsuelo.position, revisarsuelo, capasuelo);

        float mover = Input.GetAxis("Horizontal");
        if (mover > 0 && !volteaderecha)
        {
            voltear();
        }
        else if (mover < 0 && volteaderecha)
        {
            voltear();
        }
        if (isgameover == false)
        {
            sans.velocity = new Vector2(mover * maxspeed, sans.velocity.y);
        }
        
    }

    void voltear()
    {
        volteaderecha = !volteaderecha;
        sansvoltea.flipX = !sansvoltea.flipX;
    }
    public void puedesonomoverte()
    {
        puedoaccion = !puedoaccion;
    }
}