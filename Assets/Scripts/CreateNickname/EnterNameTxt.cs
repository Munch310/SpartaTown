using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterNameTxt : MonoBehaviour
{
    public Text _nicknameText; // UI Text 컴포넌트를 가리키는 변수

    // 이 함수를 호출하여 닉네임을 설정합니다.
    public void SetPlayerNickname(string nickname)
    {
        // nicknameText를 사용하여 UI Text에 닉네임을 설정합니다.
        _nicknameText.text = nickname;
    }
}
