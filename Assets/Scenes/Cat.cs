using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position += Vector3.right * 5;
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += new Vector3(0,0,45) * Time.deltaTime;
    }
}
