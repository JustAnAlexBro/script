// Эти строки подключают "библиотеки" (наборы готовых функций) из Unity
using UnityEngine;                 // Основные игровые функции (персонажи, физика и т.д.)

// Наш класс (скрипт) называется Teleport. MonoBehaviour — значит его можно повесить на объект в Unity
public class Teleport : MonoBehaviour
{
    // Это публичная переменная — её можно менять прямо в Unity!
    // Здесь хранится точка, куда мы телепортируем игрока
    public Transform teleportPoint;
    // Этот метод срабатывает, когда другой объект ВХОДИТ в зону триггера
    void OnTriggerEnter(Collider other)
    {
        // Берём позицию (координаты) телепорта (teleportPoint) 
        // и перемещаем на неё объект, который вошёл в триггер (other)
        other.transform.position = teleportPoint.position;
    }
}