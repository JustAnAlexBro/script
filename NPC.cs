// ������ ����������� ����������� ��� ��� ������ � Unity
using UnityEngine;                 // �������� ������������ ��� Unity

// ���������� ������ NPC, ������� ����������� �� MonoBehaviour (������� ����� ��� ���� �������� Unity)
public class NPC : MonoBehaviour
{
    // ��������� ���� ��� �������� NPC � ��������� �� ��������� 5
    // public ������ ���� ��������� � ���������� Unity
    public int health = 5;

    // ��������� ���� ��� ������ NPC � ��������� �� ��������� 1
    public int level = 1;

    // ��������� ���� ��� �������� NPC � ��������� �� ��������� 1.2
    // float ������������ ��� ����� � ��������� ������
    public float speed = 1.2f;
    // ����� Start() ���������� ���� ��� ��� �������� �������
    void Start()
    {
        // ����������� �������� NPC �� ��� �������
        health = health + level;

        // ������� � ������� ������� ���������� ������
        // � Unity ��� ����� ������������ � ���� Console
        print("������: " + health);
    }
    // ����� Update() ���������� ������ ����
    void Update()
    {
        // ������ ���������� Vector3 � �������� � �� ������� ������� NPC
        // Vector3 - ��� ���������, �������������� 3D ������ (x, y, z)
        Vector3 newPosition = transform.position;

        // �������� ������� �� ��� Z (�����/�����)
        // Time.deltaTime - ����� ����� �������, ������ �������� ������� � ����������� �� ������� ������
        newPosition.z += speed * Time.deltaTime;

        // ��������� ����� ������� � NPC
        transform.position = newPosition;
    }
}