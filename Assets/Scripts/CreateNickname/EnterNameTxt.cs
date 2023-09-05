using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterNameTxt : MonoBehaviour
{
    public Text _nicknameText; // UI Text ������Ʈ�� ����Ű�� ����

    // �� �Լ��� ȣ���Ͽ� �г����� �����մϴ�.
    public void SetPlayerNickname(string nickname)
    {
        // nicknameText�� ����Ͽ� UI Text�� �г����� �����մϴ�.
        _nicknameText.text = nickname;
    }
}
