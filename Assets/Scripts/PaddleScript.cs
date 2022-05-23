using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    // private float speed;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        // speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0f, 0f);
        // Debug.Log(transform.position.x);
    }
}
