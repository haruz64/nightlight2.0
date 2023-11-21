using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LunarflyArts
{
    public class AnimationStateMachine : MonoBehaviour
    {
        Animator _animator;
        private string _currentState;

        private void Start()
        {
            _animator = GetComponent<Animator>();
        }

        public void ChangeAnimationState(string newState)
        {
            if(_currentState == newState) return;
            
            _animator.Play(newState);
            
            _currentState = newState;
        }
    }
}
