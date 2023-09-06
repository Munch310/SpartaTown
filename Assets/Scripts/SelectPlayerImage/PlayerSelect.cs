using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    public GameObject _player1; // 플레이어 1 게임 오브젝트를 인스펙터에서 설정
    public GameObject _player2; // 플레이어 2 게임 오브젝트를 인스펙터에서 설정
    public GameObject _playerSelect;

    public void SelectPlayer1()
    {
        _player1.SetActive(true);  // 플레이어 1 활성화
        _player2.SetActive(false); // 플레이어 2 비활성화
        _playerSelect.SetActive(false);
    }

    public void SelectPlayer2()
    {
        _player1.SetActive(false); // 플레이어 1 비활성화
        _player2.SetActive(true);  // 플레이어 2 활성화
        _playerSelect.SetActive(false);
    }
}
