using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Werasilz
{
    public class Rotate : MonoBehaviour
    {
        private void LateUpdate()
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, Camera.main.transform.eulerAngles.y, transform.rotation.z);
        }
    }
}
