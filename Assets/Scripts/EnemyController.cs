using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    float timer = 0;
    float timeToMove = 0.05f;
    float numOfMovement = 0;
    float speed = 0.15f;

    public GameObject enemy;
    public GameObject enemyProjectile;
    public GameObject enemyProjectileClone;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeToMove && numOfMovement < 20)
        {
            transform.Translate(new Vector3(speed, 0, 0));
            timer = 0;
            numOfMovement++;
        }
        if (numOfMovement == 20)
        {
            transform.Translate(new Vector3(0, -1f, 0));
            numOfMovement = -1;
            speed = -speed;
        }

        FireEnemy();
    }

    void FireEnemy()
    {
        if (Random.Range(0, 5000) < 1)
        {
            enemyProjectileClone = Instantiate(enemyProjectile, new Vector3(enemy.transform.position.x, enemy.transform.position.y - 0.4f, 0), enemy.transform.rotation) as GameObject;
        }
    }
}
