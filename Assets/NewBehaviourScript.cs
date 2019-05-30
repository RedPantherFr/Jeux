using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float Speed=7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {

    if(Input.GetKey(KeyCode.Q))
        {
            transform.Translate(-Vector3.right*Time.deltaTime*Speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-Vector3.left * Time.deltaTime*Speed);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(new Vector3(0,0,1) * Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * Speed);
        }
    }
}
