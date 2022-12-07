using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HilamPrototype.Abstract
{
    [CreateAssetMenu(fileName = "New Icon Map Data", menuName = "Create New Map Icon Data")]
    public class MapIconData : ScriptableObject
    {
        [Header("Door Map Icon")]
        public Sprite openDoorMapIcon;
        public Sprite lockedDoorMapIcon;
        public Sprite brokenDoorMapIcon;

        [Header("Puzzle Icon")]
        public Sprite puzzleMapIcon;
    }
}
