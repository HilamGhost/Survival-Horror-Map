using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HilamPrototype
{
    public class MapData : MonoBehaviour
    {
        [SerializeField] MapIcon[] doorIcons;
        [SerializeField] MapIcon[] puzzleIcons;


        public void ChangeDoorMapIcon(string _doorObjectName,Sprite _doorStatIcon) 
        {
            string _doorObjectUIName = _doorObjectName + "_UI";

            for (int i = 0; i < doorIcons.Length; i++)
            {
                if (doorIcons[i].transform.name == _doorObjectUIName)
                {
                    doorIcons[i].RevealIcon(_doorStatIcon);
                    break;
                }

                else if (i == doorIcons.Length - 1) Debug.LogError($"There is no room = {_doorObjectName}!");
            }
        }
        public void ChangePuzzleMapIcon(string _puzzleObjectName, Sprite _puzzleStatIcon)
        {
            string _doorObjectUIName = _puzzleObjectName + "_UI";

            for (int i = 0; i < puzzleIcons.Length; i++)
            {
                if (puzzleIcons[i].transform.name == _doorObjectUIName)
                {
                    puzzleIcons[i].RevealIcon(_puzzleStatIcon);
                    break;
                }

                else if (i == doorIcons.Length - 1) Debug.LogError($"There is no room = {_puzzleObjectName}!");
            }
        }

    }
}
