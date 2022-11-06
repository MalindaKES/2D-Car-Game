using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float speed = 8.0f;

    
    void Update()
    {
        Vector3 _tempPos = transform.position;

        _tempPos.y -= speed * Time.deltaTime;
        transform.position = _tempPos;

        if (transform.position.y <= -7.0f)
        {
            gameObject.SetActive(false); 
        }
    }

    private void OnCollisionEnter2D(Collision2D target)
    {

        if (target.gameObject.tag == "Enemy")
        {
            Destroy(target.gameObject);
        }
    }

}//class
