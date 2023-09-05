using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 1. input이 일어났을 때 발생하는 event 함수를 Controller에 등록한다.
    // event는 외부에서 호출할 수 없다.
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction); // ?. -> OnMoveEvent가 null이 아닐 때 실행
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction); // ?. -> OnLookEvent가 null이 아닐 때 실행
    }
}
