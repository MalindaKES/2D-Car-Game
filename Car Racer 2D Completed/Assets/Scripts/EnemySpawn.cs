using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public GameObject[] enemies;

    int enemyNo;
    
    public float maxPos = 2.0f;
    public float delayTimer = 0.5f;
    float timer;
    
    void Start()
    {
        timer = delayTimer;
    }


    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Vector3 enemyPos = new Vector3(Random.Range(-2.0f, 2.0f), transform.position.y,
                               transform.position.z);
            enemyNo = Random.Range(0, 6);
            Instantiate(enemies[enemyNo], enemyPos, transform.rotation);
            timer = delayTimer;
        }

    }


    //
   //public float minX = -2.0f, maxX = 2.0f;
   //public float delayTimer = 1.2f;
   //
   //public float _timer;
   //
   //
   //private void Update()
   //{
   //
   //    _timer -= Time.deltaTime;
   //
   //    if (_timer <= 0)
   //    {
   //        Vector3 _tempPos = transform.position;
   //        _tempPos.x = Random.Range(minX, maxX);
   //
   //        int _randomEnemy = Random.Range(0, enemies.Length);
   //        Instantiate(enemies[_randomEnemy], _tempPos, enemies[_randomEnemy].transform.rotation);
   //
   //        _timer = delayTimer;
   //    }
   //
   //}

    //


}//class


