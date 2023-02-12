using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager current;
    public event Action OnEnterTrigger;

    private void Awake()
    {
        current = this;
    }

    public void MugCurrentTrigger()
    {
        if (OnEnterTrigger != null)
        {
            OnEnterTrigger();
        }
    }
}
