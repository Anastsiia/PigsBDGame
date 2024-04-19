using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int mistakes;
    public int count;
    public GameObject SceneFor3;
    public GameObject SceneFor6;
    public GameObject SceneFor8;
    public GameObject mainMenu;
    public GameObject Scene2_25;
    public GameObject Scene2_26;


    private void Start()
    {
        mistakes = 0;
        count = 0;
    }

    public void AddMistakes()
    {
        mistakes++;

        if (mistakes == 3)
        {
            SceneFor3.SetActive(true);
        }

        if (mistakes == 6)
        {
            SceneFor6.SetActive(true);
        }
        if (mistakes == 8)
        {
            SceneFor8.SetActive(true);
        }
    }

    public void CounterScene2_25()
    {
        count++;


        if (count == 4)
        {
            Scene2_25.SetActive(false);
            Scene2_26.SetActive(true);
        }

    }

    public void DisableAllScenes()
    {
        // Находим все объекты с тегом "SceneObject"
        GameObject[] sceneObjects = GameObject.FindGameObjectsWithTag("Scene");

        // Перебираем все найденные объекты "сцена"
        foreach (GameObject sceneObject in sceneObjects)
        {
            // Проверяем, активен ли объект "сцена"
            if (sceneObject.activeSelf)
            {
                // Выключаем текущий активный объект "сцена"
                sceneObject.SetActive(false);
            }
        }

        // Включаем объект "главное меню"
        mainMenu.SetActive(true);
    }
}
