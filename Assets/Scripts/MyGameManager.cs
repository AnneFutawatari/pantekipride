using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SelectCharacter
{
    public class MyGameManager : MonoBehaviour
    {
        private static MyGameManager myGameManager;

        [SerializeField]
        private MyGameManagerData myGameManagerData = null;

        private void Awake()
        {
            if (myGameManager == null)
            {
                myGameManager = this;
                DontDestroyOnLoad(this);
            } else {
                Destroy(gameObject);
            }
        }

        public MyGameManagerData GetMyGameManagerData()
        {
            return myGameManagerData;
        }
    }
}