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
        [SerializeField] private float turnSpeed = 35f;
        [SerializeField] private float force = 55f;
        
        private DefaultInput _input;
        private Mover _mover;
        private Rotator _rotator;

        private bool _isForceUp;
        private float _leftRight;
        public float TurnSpeed => turnSpeed;
        public float Force => force;

        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotator = new Rotator(this);
        }

        private void FixedUpdate()
        {
            if (_isForceUp)
            {
                _mover.FixedTick();
            }

            _rotator.FixedTick(_leftRight);
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

            _leftRight = _input.LeftRight;
        }
    }
}

