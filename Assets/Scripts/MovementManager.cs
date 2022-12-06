using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{

    public int speed;
    public int dSpeed;
    public int qSpeed;

    public Space space;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * speed);
        }

        if(Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.left * Time.deltaTime * dSpeed, space);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * qSpeed, space);
        }

    }
}
