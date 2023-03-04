using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryTrash2 : MonoBehaviour
{
    [SerializeField] GameObject obj;

    public void DestroyObj()
    {
        Destroy(obj);
    }

}