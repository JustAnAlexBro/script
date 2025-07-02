using UnityEngine;                                    // ����������� ������������ (���������) ��� Unity, ������� �������� ������� ������ � ������� ��� ������ � �������� ���������, �������, ������������ � �. �.

public class Trampline : MonoBehaviour               // ������������ �� MonoBehaviour ��������� ����������� ���� ������ � ������� �������� � Unity � ������������ ����������� ������ (��������, print).
{
    void OnTriggerEnter(Collider other)               // �����, ������������� ���������� Unity, ����� ������ ��������� ������ � ���������� ���� �������� �������.
    {
        //���������� ���� ������
        other.GetComponent<Jump>().jumpStrength = 10; // �������� ��������� Jump � �������, ������� ����� � �������.

    }

    void OnTriggerExit(Collider other)
    {
        //���������� ���� ������
        other.GetComponent<Jump>().jumpStrength = 2;

    }
}
