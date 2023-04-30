using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Concretes.Controllers;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Movements
{
    public class Rotator
    {
        private Rigidbody _rigidbody;
        private PlayerController _playerController;

        public Rotator(PlayerController playerController)
        {
            _playerController = playerController;
            _rigidbody = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick(float direction)
        {
            if (direction == 0)
            {
                if (_rigidbody.freezeRotation) _rigidbody.freezeRotation = false;
                
                return;
            }

            if (!_rigidbody.freezeRotation) _rigidbody.freezeRotation = true;
            
            _playerController.transform.Rotate(Vector3.back * (Time.deltaTime * direction * _playerController.TurnSpeed));
        }
    }
}

