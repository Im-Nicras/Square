using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test
{
    public class Finish : MonoBehaviour
    {
        public AudioClip winClip;
        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<ThirdPersonController>())
            {
                Game_administrator.Singleton.Win_game();
                AudioSource.PlayClipAtPoint(winClip, transform.position);
            }
        }
    }
}