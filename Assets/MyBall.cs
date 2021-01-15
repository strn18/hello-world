using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 25, ForceMode.Impulse);
            Debug.Log(rigid.velocity);
        }
        */
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"),
            0, Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);
        
        //rigid.AddTorque(Vector3.back);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "Cube (1)")
        {
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }
}
