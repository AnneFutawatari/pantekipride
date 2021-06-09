using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SelectCharacter
{
    public class SceneTransition : MonoBehaviour
    {
        private MyGameManagerData myGameManagerData;

        // Start is called before the first frame update
        private void Start()
        {
            myGameManagerData = FindObjectOfType<MyGameManager>().GetMyGameManagerData();
        }

        public void GoToOtherScene(string stage)
        {
            myGameManagerData.SetNextSceneName(stage);
            SceneManager.LoadScene("SelectCharacter");
        }
    }
}
