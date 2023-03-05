using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteGenerator : MonoBehaviour
{
    public List<Sprite> spriteList;
    // Start is called before the first frame update
    void Start()
    {
        //gets random sprite from the list of sprites
        GetComponent<SpriteRenderer>().sprite = spriteList[Random.Range(0, spriteList.Count)];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
