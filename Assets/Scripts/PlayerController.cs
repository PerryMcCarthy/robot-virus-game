using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public float steerSpeed = 20;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello world");
    }

    void Update()
     {
        float steertValue = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float gasValue = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        Vector3 positionChange = Vector3.forward * gasValue;


        transform.Rotate(Vector3.up, steertValue);
        transform.Translate(positionChange);

    }

}
