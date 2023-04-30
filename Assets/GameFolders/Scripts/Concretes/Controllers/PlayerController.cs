using System;
using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Concretes.Inputs;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float force;
        
        private Rigidbody _rigidbody;
        private DefaultInput _input;

        private bool _isForceUp;
        
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _input = new DefaultInput();
        }

        private void FixedUpdate()
        {
            if (_isForceUp)
            {
                _rigidbody.AddForce(Vector3.up * (Time.deltaTime * force));
            }
        }

        private void Update()
        {
            if (_input.IsForceUp)
            {
                _isForceUp = true;
            }
            else
            {
                _isForceUp = false;
            }
        }
    }
}

