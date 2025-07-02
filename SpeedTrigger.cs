using UnityEngine;                                                          //1//    - Подключение пространства имен Unity, необходимое для работы с MonoBehaviour и другими Unity-классами.

public class SpeedTrigger : MonoBehaviour                                   //2//    - Объявление класса SpeedTrigger, который наследуется от MonoBehaviour (базовый класс для всех скриптов Unity).
{
    public float speedFactor = 2.5f;                                        //2.1//  - Объявление публичной(можно менять в inspector) переменной speedFactor типа float со значением 2.5 по умолчанию.

    void OnTriggerEnter(Collider other)                                     //2.1m// - Метод, автоматически вызываемый Unity при входе другого коллайдера в триггер.
    {
        // Получаем компонент FirstPersonMovement у объекта, вошедшего в триггер,
        // и увеличиваем его скорость бега в speedFactor раз
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;  //2.1m.1// - Увеличение скорости бега игрока.
    }

    void OnTriggerExit(Collider other)                                      //2.2m// - Метод, автоматически вызываемый Unity при выходе другого коллайдера из триггера
    {
        // Получаем компонент FirstPersonMovement у объекта, вышедшего из триггера,
        // и возвращаем его скорость бега к исходному значению (делим на speedFactor)
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;  //2.2m.1// - Уменьшение скорости бега игрока.
    }
}