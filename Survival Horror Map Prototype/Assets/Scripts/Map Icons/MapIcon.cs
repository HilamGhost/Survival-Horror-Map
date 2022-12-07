using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HilamPrototype
{
    public class MapIcon : MonoBehaviour
    {
        [SerializeField] bool isFounded;

        Image iconUiImage;
        

        private void Awake()
        {
            iconUiImage = GetComponent<Image>();
            ChangeIconImage(null);
        }
       

        public void RevealIcon(Sprite wantedImage) 
        {
            isFounded = true;
            ChangeIconImage(wantedImage);
        }
        public void ChangeIconImage(Sprite wantedImage) 
        {
            if (isFounded) 
            {
                var opaqueColor = Color.white;
                iconUiImage.color = opaqueColor;

                iconUiImage.sprite = wantedImage;
            }
            else
            {
                var transparentColor = Color.white;
                transparentColor.a = 0;

                iconUiImage.color = transparentColor;
            }
        }
    }
}
