using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    public GameObject _player1; // �÷��̾� 1 ���� ������Ʈ�� �ν����Ϳ��� ����
    public GameObject _player2; // �÷��̾� 2 ���� ������Ʈ�� �ν����Ϳ��� ����
    public GameObject _playerSelect;

    public void SelectPlayer1()
    {
        _player1.SetActive(true);  // �÷��̾� 1 Ȱ��ȭ
        _player2.SetActive(false); // �÷��̾� 2 ��Ȱ��ȭ
        _playerSelect.SetActive(false);
    }

    public void SelectPlayer2()
    {
        _player1.SetActive(false); // �÷��̾� 1 ��Ȱ��ȭ
        _player2.SetActive(true);  // �÷��̾� 2 Ȱ��ȭ
        _playerSelect.SetActive(false);
    }
}
