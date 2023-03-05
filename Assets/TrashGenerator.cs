using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashGenerator : MonoBehaviour
{

    public GameObject trash;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(trash, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
