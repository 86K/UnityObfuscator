using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMonoBehaviour : MonoBehaviour
{
    /// <summary>
    /// 测试：整数预设混淆
    /// </summary>
    [SerializeField] private int num = 10;

    /// <summary>
    /// 测试：方法混淆
    /// </summary>
    public void TestFunc()
    {
        // 测试：局部变量混淆
        string localString = "123";
    }
}
