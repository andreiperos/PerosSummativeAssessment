using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Define private variables
    public float _speed;
    public Rigidbody _rigidbody;

    float mx;

    Vector3 _velocity;
    Renderer _renderer;

    private void Update(){
        mx = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        
        Vector2 movement = new Vector2(mx * _speed, _rigidbody.velocity.y);
        _rigidbody.velocity = movement;

        // _rigidbody.velocity = _rigidbody.velocity.normalized * _speed;
        //_velocity = _rigidbody.velocity;

        if (!_renderer.isVisible)
        {
            GameManager.Instance.Balls--;
            Destroy(gameObject);
        }
    }

    void Start()
    {        
        _rigidbody = GetComponent<Rigidbody>();
        _renderer = GetComponent<Renderer>();
    }
          
    private void OnCollisionEnter(Collision collision)
    {
        _rigidbody.velocity = Vector3.Reflect(_velocity, collision.contacts[0].normal);
    }

    //void Launch()
    //{
        //_rigidbody.velocity = Vector3.up * _speed;
    //}
}
