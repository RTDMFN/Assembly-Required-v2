using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MouseLogic
{

    public static Vector3 GetMousePositionInWorld(){
        Camera mainCamera = Camera.main;
        Vector3 mousePositionOnScreen = Input.mousePosition;
        Ray ray = mainCamera.ScreenPointToRay(mousePositionOnScreen);
        RaycastHit raycastHit;
        Physics.Raycast(ray, out raycastHit, float.MaxValue,GridLogic.LayerMaskLego);

        if(raycastHit.collider != null){
            Vector3 mousePositionInWorld = raycastHit.point;
            return mousePositionInWorld;
        }else{
            Vector3 mousePositionInWorld = new Vector3(int.MaxValue,int.MaxValue,int.MaxValue);
            return mousePositionInWorld;
        }
    }

    public static Vector3 GetMousePositionInWorld(LayerMask layerMask){
        Camera mainCamera = Camera.main;
        Vector3 mousePositionOnScreen = Input.mousePosition;
        Ray ray = mainCamera.ScreenPointToRay(mousePositionOnScreen);
        RaycastHit raycastHit;
        Physics.Raycast(ray, out raycastHit, float.MaxValue,layerMask);

        if(raycastHit.collider != null){
            Vector3 mousePositionInWorld = raycastHit.point;
            return mousePositionInWorld;
        }else{
            Vector3 mousePositionInWorld = new Vector3(int.MaxValue,int.MaxValue,int.MaxValue);
            return mousePositionInWorld;
        }
    }

    public static Collider GetColliderBehindMouseInWorld(){
        Camera mainCamera = Camera.main;
        Vector3 mousePositionOnScreen = Input.mousePosition;
        Ray ray = mainCamera.ScreenPointToRay(mousePositionOnScreen);
        RaycastHit raycastHit;
        Physics.Raycast(ray, out raycastHit, float.MaxValue,GridLogic.LayerMaskLego);

        if(raycastHit.collider != null){
            Collider colliderBehindMouseInWorld = raycastHit.collider;
            return colliderBehindMouseInWorld;
        }else{
            Collider colliderBehindMouseInWorld = null;
            return colliderBehindMouseInWorld;
        }
    }

    public static Collider GetColliderBehindMouseInWorld(LayerMask layerMask){
        Camera mainCamera = Camera.main;
        Vector3 mousePositionOnScreen = Input.mousePosition;
        Ray ray = mainCamera.ScreenPointToRay(mousePositionOnScreen);
        RaycastHit raycastHit;
        Physics.Raycast(ray, out raycastHit, float.MaxValue,layerMask);

        if(raycastHit.collider != null){
            Collider colliderBehindMouseInWorld = raycastHit.collider;
            return colliderBehindMouseInWorld;
        }else{
            Collider colliderBehindMouseInWorld = null;
            return colliderBehindMouseInWorld;
        }
    }
}
