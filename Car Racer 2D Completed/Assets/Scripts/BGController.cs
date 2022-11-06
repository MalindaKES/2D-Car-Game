using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGController : MonoBehaviour
{
    public float speed =1.8f;

    private Renderer _renderer;
    private Vector2 _offset;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        _offset = new Vector2(0f, Time.time * speed);
        _renderer.material.mainTextureOffset = _offset;
    }




}//class
