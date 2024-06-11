using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public interface IUIState
{
    void Enter();
    void Exit();
}
