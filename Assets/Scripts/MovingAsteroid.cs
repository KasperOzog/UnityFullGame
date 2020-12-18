using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAsteroid : MonoBehaviour
{
    private float speed = 40;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);

        if (transform.position.z < -200)
        {
            Destroy(gameObject);
        }
    }
}
