using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HilamPrototype
{
    public abstract class Interactable : MonoBehaviour
    {
        [SerializeField] protected bool isInteracted;
        private void OnMouseDown()
        {
            Interact();
        }
        public abstract void Interact(); 
        
    }
}
