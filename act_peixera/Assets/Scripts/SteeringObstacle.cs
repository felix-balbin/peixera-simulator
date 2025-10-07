using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringObstacle : MonoBehaviour {

    private void OnEnable() {
        SteeringObstacleManager.instance.RegisterObstacle(this);
    }

    private void OnDisable() {
        SteeringObstacleManager.instance.UnRegisterObstacle(this);
    }

    public float GetRadius() {
        return transform.lossyScale.x;
    }

}
