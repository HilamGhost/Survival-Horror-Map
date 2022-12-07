using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace HilamPrototype
{
    public class DialogueManager : Singleton<DialogueManager>
    {
        [SerializeField] TextMeshProUGUI dialoguePro;
        [SerializeField] string defaultText;
        [SerializeField] bool isContinuing;
        [SerializeField] AudioClip dialogueSound;

        public IEnumerator ChangeDialogueText(string wantedText) 
        {
            if (isContinuing) yield break;

            isContinuing = true;
            AudioManager.Instance.PlayAudioOneShot(dialogueSound);
            dialoguePro.text = wantedText;
            yield return new WaitForSeconds(2);
            dialoguePro.text = defaultText;
            isContinuing = false;
        }
    }
}
