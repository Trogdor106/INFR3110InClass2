using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PluginTester : MonoBehaviour
{
    [StructLayout(LayoutKind.Sequential)]
    struct Vector2D
    {
        public float x;
        public float y;
    }

    const string DLL_NAME = "INFR3110-DLL-InClass";

    [DllImport(DLL_NAME)]
    private static extern int GetID();


    [DllImport(DLL_NAME)]
    private static extern void SetID(int id);

    [DllImport(DLL_NAME)]
    private static extern Vector2D GetPosition();

    [DllImport(DLL_NAME)]
    private static extern void SetPosition(float x, float y);

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown((KeyCode.S)))
        {
            SetID(12);
            SetPosition(4.25f, 1.17f);

            Debug.Log(GetID());
            Debug.Log(GetPosition().x);
            Debug.Log(GetPosition().y);
        }
    }
}
