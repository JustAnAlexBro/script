using UnityEngine;                                    // Подключение пространства (библиотек) имён Unity, которое содержит базовые классы и функции для работы с игровыми объектами, физикой, компонентами и т. д.

public class Trampline : MonoBehaviour               // Наследование от MonoBehaviour позволяет прикреплять этот скрипт к игровым объектам в Unity и использовать стандартные методы (например, print).
{
    void OnTriggerEnter(Collider other)               // Метод, автоматически вызываемый Unity, когда другой коллайдер входит в триггерную зону текущего объекта.
    {
        //Увеличение силы прыжка
        other.GetComponent<Jump>().jumpStrength = 10; // Получает компонент Jump у объекта, который вошёл в триггер.

    }

    void OnTriggerExit(Collider other)
    {
        //Уменьшение силы прыжка
        other.GetComponent<Jump>().jumpStrength = 2;

    }
}
