using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CarController : MonoBehaviour
{
    public float speed;

    public float maxPos = 2.5f;

    private Vector3 _myPosition;

    public uiManager _ui;

    //public SoundController sm;

    private void Awake()
    {
        //sm.takeoff.Play();
    }

    void Start()
    {
        
        //_ui = GetComponent<uiManager>();
        _myPosition = transform.position; 
    }
    
    void Update()
    {
        _myPosition.x += Input.GetAxis("Horizontal") *speed* Time.deltaTime;

        _myPosition.x = Mathf.Clamp(_myPosition.x, -2.5f, 2.5f); //limit the x axis area
        
        transform.position = _myPosition;


        
        _myPosition.y += Input.GetAxis("Vertical") *speed* Time.deltaTime;
        
        _myPosition.y = Mathf.Clamp(_myPosition.y, -4.0f, -1.0f); // limit the y axis area
        
        transform.position = _myPosition;

    }//bounds

 

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag=="Enemy")
        {
            Destroy(this.gameObject);
            //SceneManager.LoadScene(SceneManager.GetSceneAt(0).name); //restart the game
            _ui.gameOverActive();
           //sm.takeoff.Stop();
           //sm.acceleration.Stop();
                
        }
    }
  

}//class
