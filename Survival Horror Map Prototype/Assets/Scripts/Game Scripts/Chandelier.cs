using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HilamPrototype
{
    public class Chandelier : MonoBehaviour
    {
      
        void Start()
        {
            Invoke("Swing", 2);
        }

        void Swing() 
        {
            GetComponent<Rigidbody>().position += new Vector3(1, 0, 0);
        }

    }
}
