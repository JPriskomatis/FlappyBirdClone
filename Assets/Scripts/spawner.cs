using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float queueTime = 1.5f;
    private float time = 0;

    public float height;

    public ObstacleFactory obstacleFactory;



    void Update()
    {
        if (time > queueTime)
        {
            // Random position within the specified height
            Vector3 spawnPosition = transform.position + new Vector3(0, Random.Range(-height, height), 0);



            // Spawn an obstacle
            ObstacleBase obstacle = SpawnObstacle(SelectObstacle(), spawnPosition);

            // Destroy the obstacle after a delay
            Destroy(obstacle.gameObject, 10);

            // Reset the timer
            time = 0;
        }

        // Increment the timer
        time += Time.deltaTime;
    }

    //We select randomly an obstacle;
    ObstacleType SelectObstacle()
    {
        ObstacleType[] obstacleTypes = (ObstacleType[])System.Enum.GetValues(typeof(ObstacleType));

        ObstacleType selectedObstacle = obstacleTypes[Random.Range(0, obstacleTypes.Length)];

        return selectedObstacle;
    } 

    ObstacleBase SpawnObstacle(ObstacleType type, Vector3 position)
    {
        // Use the factory to create the obstacle
        return obstacleFactory.CreateObstacle(type, position);
    }
}
