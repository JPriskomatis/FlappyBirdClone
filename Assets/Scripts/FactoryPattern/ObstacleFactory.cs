using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ObstacleType
{
    Pipe,
    Fire
}

public class ObstacleFactory : MonoBehaviour
{
    public ObstacleBase CreateObstacle(ObstacleType type, Vector3 position)
    {
        ObstacleBase obstacle = null;

        switch (type)
        {
            case ObstacleType.Pipe:
                obstacle = Instantiate(Resources.Load<Pipe>("PipePrefab"), position, Quaternion.identity);
                break;
            case ObstacleType.Fire:
                obstacle = Instantiate(Resources.Load<Fire>("FirePrefab"), position, Quaternion.identity);
                break;
        }

        obstacle.Initialize();
        return obstacle;
    }
}
