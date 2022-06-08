using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public GameObject target;
    public new Transform camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (camera.transform.position.x - target.transform.position.x >= -0.3f || camera.transform.position.x - target.transform.position.x <= 0.3f)
            transform.position = new Vector3(target.transform.position.x, 0, -10);
    }
}
