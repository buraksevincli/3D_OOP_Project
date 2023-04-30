using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GameFolders.Scripts.Concretes.Inputs
{
    public class DefaultInput
    {
        private DefaultAction _input;

        public bool IsForceUp { get; private set; }

        public DefaultInput()
        {
            _input = new DefaultAction();

            _input.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();
            
            _input.Enable();
        }
    }
}

