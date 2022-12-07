using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HilamPrototype
{
    public class Puzzle : Interactable
    {
        [SerializeField] string customDialogue;

        public override void Interact()
        {
            if (!isInteracted)
            {
                isInteracted = true;
                MapController.Instance.DrawPuzzleIcon(transform.name);
            }
            
            StartCoroutine(DialogueManager.Instance.ChangeDialogueText(customDialogue));
        }
    }
}
