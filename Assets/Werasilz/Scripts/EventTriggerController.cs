using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Werasilz
{
    public class EventTriggerController : MonoBehaviour
    {
        [SerializeField] private UnityEvent startTrigger;

        public float middleDelayTime;
        [SerializeField] private UnityEvent middleTrigger;

        public float endDelayTime;
        [SerializeField] private UnityEvent endTrigger;

        // startTrigger.Invoke();

        // if (middleTrigger != null)
        // {
        //     StartCoroutine(MiddleDelay());
        // }

        // if (endTrigger != null)
        // {
        //     StartCoroutine(EndDelay());
        // }

        public void StartTrigger()
        {
            startTrigger.Invoke();
        }

        IEnumerator MiddleDelay()
        {
            yield return new WaitForSeconds(middleDelayTime);
            middleTrigger.Invoke();
        }

        IEnumerator EndDelay()
        {
            yield return new WaitForSeconds(endDelayTime);
            endTrigger.Invoke();
        }
    }
}
