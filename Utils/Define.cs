using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public enum Layer
    {
        Monster = 7,
        Ground = 8,
        Block = 9
    }
    public enum Scene
    {
        Unknown,
        Login,
        Lobby,
        Game
    }

    public enum Sound
    {
        Bgm,
        Effect,
        MaxCount
    }

    public enum UIEvent
    {
        Click,
        Drag,
    }

    public enum MouseEvent
    {
        Press,
        PointerDown,
        PointerUp,
        Click,
        Null
    }

    public enum CameraMode
    {
        QuarterView
    }
}
