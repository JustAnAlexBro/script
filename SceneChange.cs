using UnityEngine;
using UnityEngine.SceneManagement; // Используем стандартную систему управления сценами

public class SceneChange : MonoBehaviour
{
    // Имя сцены для загрузки (должно быть в Build Settings)
    public string sceneName;

    // Добавлен параметр Collider - триггер требует коллайдера для работы
    void OnTriggerEnter(Collider other) // Collider
    {
        // Загрузка сцены через SceneManager (работает в билде)
        SceneManager.LoadScene(sceneName);
    }
}