using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartForce2D : MonoBehaviour
{
    public Vector2 startForce;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForce(startForce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
