using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Werasilz
{
    public class CameraController : MonoBehaviour
    {
        private bool isMoving;
        private GameObject moveTarget;

        public void MoveToPosition(GameObject target)
        {
            moveTarget = target;
            isMoving = true;
            StartCoroutine(ResetMoving());
        }

        private void Update()
        {
            if (isMoving)
            {
                Vector3 pos = new Vector3(moveTarget.transform.position.x, moveTarget.transform.position.y + 1.35f, moveTarget.transform.position.z);
                transform.position = pos;
            }
        }

        IEnumerator ResetMoving()
        {
            yield return new WaitForSeconds(0.5f);
            isMoving = false;
            moveTarget = null;
            StopAllCoroutines();
        }
    }
}
