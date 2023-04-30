using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Concretes.Controllers;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Movements
{
    public class Mover
    {
        private PlayerController _playerController;
        private Rigidbody _rigidbody;

        public Mover(PlayerController playerController)
        {
            _playerController = playerController;
            _rigidbody = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick()
        {
            _rigidbody.AddRelativeForce(Vector3.up * (Time.deltaTime * _playerController.Force));
        }
    }
}

