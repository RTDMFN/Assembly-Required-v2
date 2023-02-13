using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GridLogic
{
    //Dimensions of 1 Lego Brick Dot
    private static float x = 0.2f;
    private static float y = 0.1f;
    private static float z = 0.2f;

    public static readonly Vector3 Grid = new Vector3(x,y,z);
    public static int LayerMaskLego = LayerMask.GetMask("Lego");

    public static Vector3 FindNearestPointOnGrid(Vector3 input){
        Vector3 nearestPointOnGrid = new Vector3(Mathf.Round(input.x / Grid.x) * Grid.x,
                                                 Mathf.Round(input.y / Grid.y) * Grid.y,
                                                 Mathf.Round(input.z / Grid.z) * Grid.z);
        return nearestPointOnGrid;
    }
}
