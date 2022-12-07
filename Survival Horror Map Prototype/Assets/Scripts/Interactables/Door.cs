using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HilamPrototype
{
    public class Door : Interactable
    {
        [SerializeField] DoorStats doorStat;
        [SerializeField] string customDialogue;
        
        [SerializeField] Transform movePos;
        [Space]
        [SerializeField] AudioClip doorOpenAudio;
        [SerializeField] AudioClip doorClosedAudio;
        public override void Interact()
        {
            PlaySound();

            if (!isInteracted) 
            {
                isInteracted = true;
                ChangeDialogue();
                MapController.Instance.DrawDoorIcon(transform.name,doorStat);
            }
            else
            {
                switch (doorStat) 
                {
                    case DoorStats.Open:
                        PlayerController.Instance.MoveRoom(movePos.position);
                        break;
                    case DoorStats.Broken: 
                        ChangeDialogue(); 
                        break;
                    case DoorStats.Locked: 
                        ChangeDialogue();
                        break;
                }
            }
            
        }


        void ChangeDialogue() 
        {
            string dialogue = customDialogue == "" ? $"Door is {doorStat}": customDialogue;
            StartCoroutine(DialogueManager.Instance.ChangeDialogueText(dialogue));
        }
        void PlaySound() 
        {
            AudioClip _playedAudioClip = doorStat switch 
            {
                DoorStats.Open => isInteracted ? doorOpenAudio:null,
                DoorStats.Locked => doorClosedAudio,
                DoorStats.Broken => doorClosedAudio,
                DoorStats.Unlocked => isInteracted ? doorOpenAudio : null,
                _ => null
            };
            AudioManager.Instance.PlayAudioOneShot(_playedAudioClip);
        }
    }
    public enum DoorStats 
    {
        Open,
        Locked,
        Broken,
        Unlocked
    }
}
