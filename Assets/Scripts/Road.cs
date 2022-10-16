using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MoveLeft
{
    public Transform nextPos;

    public void SetNextPos(Road road){
        road.transform.position = nextPos.position;
    }
    private void Update() {
        Move();
    }   
}
