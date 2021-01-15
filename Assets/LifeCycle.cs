using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    private void Start()
    {

    }
    private void Update()
    {
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime * 2, 
            Input.GetAxisRaw("Vertical") * Time.deltaTime * 2, 0);
        transform.Translate(vec);
    }
}
