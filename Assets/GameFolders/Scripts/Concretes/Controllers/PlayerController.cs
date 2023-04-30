using System;
using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Concretes.Inputs;
using GameFolders.Scripts.Concretes.Movements;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float force;
        
        private DefaultInput _input;
        private Mover _mover;

        private bool _isForceUp;
        
        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(GetComponent<Rigidbody>());
        }

        private void FixedUpdate()
        {
            if (_isForceUp)
            {
                _mover.FixedTick();
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

