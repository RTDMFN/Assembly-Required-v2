using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [HideInInspector]
    public BoxCollider brickCollider;

    public void Awake(){
        brickCollider = GetComponent<BoxCollider>();
    }
}
