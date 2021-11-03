using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Werasilz
{
    public class NPCController : MonoBehaviour
    {
        Animator animator;

        private void Awake()
        {
            animator = GetComponent<Animator>();
        }

        public void PlayAnimation(string animationName)
        {
            animator.CrossFade(animationName, 0.2f);
        }

        public void SetBoolAnimation(string boolName)
        {
            animator.SetBool(boolName, true);
        }

        public void ResetBoolAnimation(string boolName)
        {
            animator.SetBool(boolName, false);
        }
    }
}
