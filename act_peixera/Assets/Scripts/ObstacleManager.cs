using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringObstacleManager : MonoBehaviour {
    #region Singleton
    static SteeringObstacleManager steeringObstacleManager;
    public static SteeringObstacleManager instance {
        get {
            return RequestSteeringObstacleManager();
        }
    }

    private static SteeringObstacleManager RequestSteeringObstacleManager() {
        if (!steeringObstacleManager) {
            GameObject steeringObstacleManagerObj = new GameObject("SteeringObstacleManager");
            steeringObstacleManager = steeringObstacleManagerObj.AddComponent<SteeringObstacleManager>();
            steeringObstacleManager.obstacles = new List<SteeringObstacle>();
        }
        return steeringObstacleManager;
    }

    private void Awake() {
        if (steeringObstacleManager == null) {
            steeringObstacleManager = this;
            steeringObstacleManager.obstacles = new List<SteeringObstacle>();

        } else if (steeringObstacleManager != this) {
            Destroy(gameObject);
        }
    }
    #endregion

    public List<SteeringObstacle> obstacles = new List<SteeringObstacle>();

    public void RegisterObstacle(SteeringObstacle o) {
        obstacles.Add(o);
    }

    public void UnRegisterObstacle(SteeringObstacle o) {
        obstacles.Remove(o);
    }


}
