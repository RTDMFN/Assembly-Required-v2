using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBuild : MonoBehaviour
{
    public Brick PrefabBrick;

    protected Brick currentBrick;
    protected bool positionWasFound;

    private void Start(){
        SetNextBrick();
    }

    private void Update(){
        PlaceBrick();
        RotateBrick();
        DeleteBrick();
    }

    private void SetNextBrick(){
        currentBrick = Instantiate(PrefabBrick);
        currentBrick.brickCollider.enabled = false;
    }

    private void PlaceBrick(){
        if(currentBrick != null){
            Vector3 mousePositionInWorld = MouseLogic.GetMousePositionInWorld();
            Vector3 closestGridPosition = GridLogic.FindNearestPointOnGrid(mousePositionInWorld);
            Vector3 placePosition = closestGridPosition;
            for(int i = 0; i < 10; i++){
                Vector3 absoluteCenterOfBrick = placePosition + currentBrick.transform.rotation * currentBrick.brickCollider.center;
                var collider = Physics.OverlapBox(absoluteCenterOfBrick,
                                                            currentBrick.brickCollider.size / 2, 
                                                            currentBrick.transform.rotation, 
                                                            GridLogic.LayerMaskLego);
                Debug.DrawLine(mousePositionInWorld,absoluteCenterOfBrick);

                positionWasFound = collider.Length == 0;

                if(positionWasFound) break;
                else placePosition.y += GridLogic.Grid.y;
            }

            if(positionWasFound) currentBrick.transform.position = placePosition;
            else currentBrick.transform.position = closestGridPosition;
        }

        if(Input.GetMouseButtonDown(0)){
            currentBrick.brickCollider.enabled = true;
            var rot = currentBrick.transform.rotation;
            currentBrick = null;
            SetNextBrick();
            currentBrick.transform.rotation = rot;
        }
    }

    private void RotateBrick(){
        if(Input.GetKeyDown(KeyCode.R)){
            currentBrick.transform.Rotate(Vector3.up,90);
        }
    }

    private void DeleteBrick(){
        if(Input.GetKeyDown(KeyCode.X)){
            var brickToDelete = MouseLogic.GetColliderBehindMouseInWorld();
            bool isThisABrick = brickToDelete.GetComponent<Brick>() != null;
            if(brickToDelete != null && isThisABrick) Destroy(brickToDelete.gameObject);
        }
    }
}
