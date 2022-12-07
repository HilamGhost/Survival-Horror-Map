using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HilamPrototype
{
    public class Inspectable : Interactable
    {
        [SerializeField] string inspectQuote;
        public override void Interact()
        {
            StartCoroutine(DialogueManager.Instance.ChangeDialogueText(inspectQuote));
        }
    }
}
