using UnityEngine;

namespace SelectCharacter
{
    public class GameStartButton : MonoBehaviour
    {
        private SceneTransition sceneTransition;

        // Start is called before the first frame update
        private void Start()
        {
            sceneTransition = FindObjectOfType<SceneTransition>();
        }

        public void OnGameStart()
        {
            sceneTransition.GameStart();
        }
    }
}