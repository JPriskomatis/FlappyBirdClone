using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Factoryspace
{
    //An enum list of all our obstacles;
    public enum ObstacleType
    {
        Pipe,
        Fire,
        Banana,
        Tower
    }

    public class ObstacleFactory : MonoBehaviour
    {
        //Iterations through our type to see which obstacle we will instantiate;
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
                case ObstacleType.Banana:
                    obstacle = Instantiate(Resources.Load<Banana>("BananaPrefab"), position, Quaternion.identity);
                    break;
                case ObstacleType.Tower:
                    obstacle = Instantiate(Resources.Load<Tower>("TowerPrefab"), position, Quaternion.identity);
                    break;
            }

            //We cann the Initialize function from within our obstalce;
            obstacle.Initialize();
            return obstacle;
        }
    }

}
