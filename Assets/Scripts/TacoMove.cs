using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacoMove : MonoBehaviour
{
     float turnspeed = 18.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * turnspeed * Input.GetAxis("Horizontal") * Time.deltaTime);
        transform.Translate(0f, 0f , turnspeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}
