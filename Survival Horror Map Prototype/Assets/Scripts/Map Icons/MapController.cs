using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using HilamPrototype.Abstract;

namespace HilamPrototype
{
    public class MapController : Singleton<MapController>
    {
        [SerializeField] MapData currentMap;
        [SerializeField] GameObject mapBG;
        [Space]
        [SerializeField] MapIconData mapIconData;
        [Space]
        [SerializeField] AudioClip mapOpenCloseSound;

        public MapIconData MapIconData => mapIconData;

        protected override void Awake()
        {
            base.Awake();
            
            // This is for making map assignments
            mapBG.SetActive(true);
            mapBG.SetActive(false);

        }
        public void InteractWithMap(bool canOpen) 
        {
            currentMap.gameObject.SetActive(canOpen);
            mapBG.SetActive(canOpen);
            AudioManager.Instance.PlayAudioOneShot(mapOpenCloseSound);
        }

        public void DrawDoorIcon(string _doorName,DoorStats _doorStat) 
        {
            var _doorSprite = _doorStat switch
            {
                DoorStats.Open => mapIconData.openDoorMapIcon,
                DoorStats.Locked => mapIconData.lockedDoorMapIcon,
                DoorStats.Broken => mapIconData.brokenDoorMapIcon,
                _ => null
            };

            currentMap.ChangeDoorMapIcon(_doorName,_doorSprite);
        }

        public void DrawPuzzleIcon(string _puzzleName)
        {

            var _puzzleIcon = mapIconData.puzzleMapIcon;
            currentMap.ChangePuzzleMapIcon(_puzzleName,_puzzleIcon);
        }
    }
}
