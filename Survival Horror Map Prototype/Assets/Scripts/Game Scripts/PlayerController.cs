using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace HilamPrototype
{
    /// <summary>
    /// It's only used for Open and Close Map
    /// And Teleportion
    /// </summary>
    public class PlayerController : Singleton<PlayerController>
    {
        bool isMapOpen;
        [SerializeField] MapController mapController;
        [Space]
        [SerializeField] Image fadeInOut;
        Camera mainCamera;
       

        protected override void Awake()
        {
            base.Awake();
            mainCamera = Camera.main;
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                isMapOpen = !isMapOpen;
                mapController.InteractWithMap(isMapOpen);
            }
        }

        public void MoveRoom(Vector3 movePos)
        {
            fadeInOut.DOFade(1, 1).OnComplete(() => 
            {
                mainCamera.transform.position = movePos;
                fadeInOut.DOFade(0, 1);
            });
           
        }
    }
}
