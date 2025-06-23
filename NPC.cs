// Импорт необходимых пространств имён для работы с Unity
using UnityEngine;                 // Основное пространство имён Unity

// Объявление класса NPC, который наследуется от MonoBehaviour (базовый класс для всех скриптов Unity)
public class NPC : MonoBehaviour
{
    // Публичное поле для здоровья NPC с значением по умолчанию 5
    // public делает поле доступным в инспекторе Unity
    public int health = 5;

    // Публичное поле для уровня NPC с значением по умолчанию 1
    public int level = 1;

    // Публичное поле для скорости NPC с значением по умолчанию 1.2
    // float используется для чисел с плавающей точкой
    public float speed = 1.2f;
    // Метод Start() вызывается один раз при создании объекта
    void Start()
    {
        // Увеличиваем здоровье NPC на его уровень
        health = health + level;

        // Выводим в консоль текущее количество жизней
        // В Unity это будет отображаться в окне Console
        print("Жизней: " + health);
    }
    // Метод Update() вызывается каждый кадр
    void Update()
    {
        // Создаём переменную Vector3 и копируем в неё текущую позицию NPC
        // Vector3 - это структура, представляющая 3D вектор (x, y, z)
        Vector3 newPosition = transform.position;

        // Изменяем позицию по оси Z (вперёд/назад)
        // Time.deltaTime - время между кадрами, делает движение плавным и независимым от частоты кадров
        newPosition.z += speed * Time.deltaTime;

        // Применяем новую позицию к NPC
        transform.position = newPosition;
    }
}