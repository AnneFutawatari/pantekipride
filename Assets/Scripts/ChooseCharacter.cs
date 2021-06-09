using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SelectCharacter
{
    public class ChooseCharacter : MonoBehaviour
    {
        private MyGameManagerData myGameManagerData;
        private GameObject gameStartButton;

        // Start is called before the first frame update
        void Start()
        {
            myGameManagerData = FindObjectOfType<MyGameManager>().GetMyGameManagerData();
            gameStartButton = transform.parent.Find("ButtonPanel/GameStart").gameObject;
            gameStartButton.SetActive(false);
        }

        public void OnSelectCharacter(GameObject character)
        {
            EventSystem.current.SetSelectedGameObject(null);
            myGameManagerData.SetCharacter(character);
            gameStartButton.SetActive(true);
        }

        public void SwithButtonBackGround(int buttonNumber)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                if (i == buttonNumber - 1)
                {
                    transform.GetChild(i).Find("BackGround").gameObject.SetActive(true);
                }
                else
                {
                    transform.GetChild(i).Find("BackGround").gameObject.SetActive(false);
                }
            }
        }
    }
}